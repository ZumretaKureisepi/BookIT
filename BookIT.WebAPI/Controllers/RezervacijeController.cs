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
{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijeController : ControllerBase
    {
        private readonly IRezervacijeService _service;

        public RezervacijeController(IRezervacijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Rezervacija> Get([FromQuery]RezervacijeSearchRequest request)
        {
            return _service.Get(request);
        }
        [Authorize(Roles ="Klijent")]
        [HttpPost]
        public Model.Rezervacija Insert(RezervacijeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles ="Klijent,Vlasnik smještaja")]
        [HttpPut("{id}")]
        public Model.Rezervacija Update(int id, [FromBody]RezervacijeUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Rezervacija GetById(int id)
        {
            return _service.GetById(id);
        }



    }
}