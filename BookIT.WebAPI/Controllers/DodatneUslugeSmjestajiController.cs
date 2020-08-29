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
    public class DodatneUslugeSmjestajiController : ControllerBase
    {

        private readonly IDodatneUslugeSmjestajiService _service;

        public DodatneUslugeSmjestajiController(IDodatneUslugeSmjestajiService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.DodatnaUslugaSmjestaj> Get([FromQuery]DodatneUslugeSmjestajiSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize (Roles ="Vlasnik smještaja")]
        [HttpPost]
        public Model.DodatnaUslugaSmjestaj Insert(DodatneUslugeSmjestajiInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize (Roles ="Vlasnik smještaja")]
        [HttpPut("{id}")]
        public Model.DodatnaUslugaSmjestaj Update(int id, [FromBody]DodatneUslugeSmjestajiInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.DodatnaUslugaSmjestaj GetById(int id)
        {
            return _service.GetById(id);
        }



    }
}