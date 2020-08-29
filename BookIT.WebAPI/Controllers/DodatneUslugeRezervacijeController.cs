using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookIT.Model.Requests;
using BookIT.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookIT.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DodatneUslugeRezervacijeController : ControllerBase
    {

        private readonly IDodatneUslugeRezervacijeService _service;

        public DodatneUslugeRezervacijeController(IDodatneUslugeRezervacijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.DodatnaUslugaRezervacija> Get([FromQuery]DodatneUslugeRezervacijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize (Roles ="Klijent")]
        [HttpPost]
        public Model.DodatnaUslugaRezervacija Insert(DodatneUslugeRezervacijeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpGet("{id}")]
        public Model.DodatnaUslugaRezervacija GetById(int id)
        {
            return _service.GetById(id);
        }



    }
}