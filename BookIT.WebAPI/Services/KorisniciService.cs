using AutoMapper;
using BookIT.Model;
using BookIT.Model.Requests;
using BookIT.WebAPI.Database;
using BookIT.WebAPI.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly BookITContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(BookITContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnik> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePrezime))
            {
                query = query.Where(x => (x.Ime + " " + x.Prezime).Contains(request.ImePrezime));
            }
            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.Uloga);

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public Model.Korisnik GetById(int id)
        {
            var entity = _context.Korisnici.Where(x => x.KorisnikId == id)
                .Include(x => x.Grad.Drzava)
                .Include(x => x.Uloga)
                .FirstOrDefault();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            Database.Uloga uloga = _context.Uloge.Find(entity.UlogaId);
            if (uloga.Naziv == "Vlasnik smještaja")
                entity.VlasnikSmjestaja = new Database.VlasnikSmjestaja();
            else if (uloga.Naziv == "Klijent")
                entity.Klijent = new Database.Klijent();

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Update(int id, KorisniciUpdateRequest request)
        {
            if (BasicAuthenticationHandler.user.Uloga.Naziv != "Administrator")
                if (id != BasicAuthenticationHandler.user.KorisnikId)
                    return null;


            var entity = _context.Korisnici.Find(id);
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrEmpty(request.Password))
            {

                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            }
            if (request.UlogaId == 0)
                request.UlogaId = entity.UlogaId;

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }



        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Korisnik Authenticiraj(string email, string pass)
        {
            var user = _context.Korisnici.Include(x => x.Uloga).FirstOrDefault(x => x.Email == email);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, pass);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<Model.Korisnik>(user);
                }
            }
            return null;
        }

        public Model.Korisnik GetCurrentUser()
        {
            var entity = _context.Korisnici.Where(x => x.KorisnikId == BasicAuthenticationHandler.user.KorisnikId)
                .Include(x => x.Grad.Drzava)
                .Include(x => x.Uloga)
                .FirstOrDefault();

            return _mapper.Map<Model.Korisnik>(entity);
        }
        public Model.Korisnik Register(KorisniciRegistracijaRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            Database.Uloga uloga = _context.Uloge.Where(x => x.Naziv == request.UlogaIme).FirstOrDefault();
            if (uloga.Naziv == "Vlasnik smještaja")
                entity.VlasnikSmjestaja = new Database.VlasnikSmjestaja();

            else if (uloga.Naziv == "Klijent")
                entity.Klijent = new Database.Klijent();
            else
                return null;//ako je uloga nesto osim vlasnik smjestaja ili klijent treba prekinuti

            entity.UlogaId = uloga.UlogaId;//dodijeliti novom korisniku u bazi ulogu koja mu je destined
            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }
    }
}
