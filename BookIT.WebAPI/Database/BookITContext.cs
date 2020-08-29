using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Database
{
    public class BookITContext:DbContext
    {
        public BookITContext()
        {
        }

        public BookITContext(DbContextOptions<BookITContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Korisnik> Korisnici { get; set; }
        public virtual DbSet<Drzava> Drzave { get; set; }
        public virtual DbSet<Grad> Gradovi { get; set; }
        public virtual DbSet<Klijent> Klijenti { get; set; }
        public virtual DbSet<Smjestaj> Smjestaji { get; set; }
        public virtual DbSet<Soba> Sobe { get; set; }
        public virtual DbSet<Uloga> Uloge { get; set; }
        public virtual DbSet<VlasnikSmjestaja> VlasniciSmjestaja { get; set; }
        public virtual DbSet<DodatnaUslugaSmjestaj> DodatneUslugeSmjestaji { get; set; }
        public virtual DbSet<DodatnaUslugaRezervacija> DodatneUslugeRezervacije { get; set; }
        public virtual DbSet<Faktura> Fakture { get; set; }
        public virtual DbSet<Rezervacija>Rezervacije { get; set; }
        public virtual DbSet<SobaRezervacija> SobeRezervacije { get; set; }
        public virtual DbSet<DodatnaUsluga> DodatneUsluge { get; set; }
        public virtual DbSet<DodatnaUslugaSoba> DodatneUslugeSobe { get; set; }
        public virtual DbSet<SmjestajSlika> SmjestajiSlike { get; set; }
        public virtual DbSet<SobaSlika> SobeSlike { get; set; }
        public virtual DbSet<SmjestajOcjena> SmjestajiOcjene { get; set; }
        public virtual DbSet<SmjestajTipDestinacije> SmjestajiTipDestinacija { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BookIT_Zavrsni;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

    }
}
