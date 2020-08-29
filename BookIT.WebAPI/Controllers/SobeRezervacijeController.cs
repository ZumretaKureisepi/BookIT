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
    public class SobeRezervacijeController : ControllerBase
    {

        private readonly ISobeRezervacijeService _service;

        public SobeRezervacijeController(ISobeRezervacijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.SobaRezervacija> Get([FromQuery]SobeRezervacijeSearchRequest request)
        {
            return _service.Get(request);
        }
        [Authorize(Roles ="Klijent")]
        [HttpPost]
        public Model.SobaRezervacija Insert(SobeRezervacijeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpGet("{id}")]
        public Model.SobaRezervacija GetById(int id)
        {
            return _service.GetById(id);
        }





    }
}