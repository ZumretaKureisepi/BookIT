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
    public class SmjestajiController : ControllerBase
    {

        private readonly ISmjestajiService _service;

        public SmjestajiController(ISmjestajiService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Smjestaj> Get([FromQuery]SmjestajiSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("clientGet")]
        public List<Model.Smjestaj> ClientGet([FromQuery]SmjestajiClientSearchRequest request)
        {
            return _service.ClientGet(request);
        }

        [Authorize(Roles ="Vlasnik smještaja")]
        [HttpPost]
        public Model.Smjestaj Insert(SmjestajiInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles ="Vlasnik smještaja")]
        [HttpPut("{id}")]
        public Model.Smjestaj Update(int id, [FromBody]SmjestajiInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Smjestaj GetById(int id)
        {
            return _service.GetById(id);
        }



        [HttpGet("GetFinalnaOcjena/{id}")]
        public double GetFinalnaOcjena(int id)
        {
            return _service.GetFinalnaOcjena(id);
        }







    }
}