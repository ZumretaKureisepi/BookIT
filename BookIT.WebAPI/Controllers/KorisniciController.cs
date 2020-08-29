using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookIT.Model.Requests;
using BookIT.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BookIT.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Korisnik> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize (Roles ="Administrator")]
        [HttpPost]
        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Korisnik Update(int id, [FromBody]KorisniciUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Korisnik GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("currentUser")]
        public Model.Korisnik GetCurrentUser()
        {
            return _service.GetCurrentUser();
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public Model.Korisnik Registracija(KorisniciRegistracijaRequest request)
        {
            return _service.Register(request);
        }
    }
}