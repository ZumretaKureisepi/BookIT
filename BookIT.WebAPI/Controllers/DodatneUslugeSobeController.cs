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
    public class DodatneUslugeSobeController : ControllerBase
    {

        private readonly IDodatneUslugeSobeService _service;

        public DodatneUslugeSobeController(IDodatneUslugeSobeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.DodatnaUslugaSoba> Get([FromQuery]DodatneUslugeSobeSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize (Roles ="Vlasnik smještaja")]
        [HttpPost]
        public Model.DodatnaUslugaSoba Insert(DodatneUslugeSobeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize (Roles ="Vlasnik smještaja")]
        [HttpPut("{id}")]
        public Model.DodatnaUslugaSoba Update(int id, [FromBody]DodatneUslugeSobeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.DodatnaUslugaSoba GetById(int id)
        {
            return _service.GetById(id);
        }



    }
}