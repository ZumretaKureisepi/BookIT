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
    public class DodatneUslugeController : ControllerBase
    {

        private readonly IDodatneUslugeService _service;

        public DodatneUslugeController(IDodatneUslugeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.DodatnaUsluga> Get([FromQuery]DodatneUslugeSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize (Roles ="Administrator")]
        [HttpPost]
        public Model.DodatnaUsluga Insert(DodatneUslugeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize (Roles ="Administrator")]
        [HttpPut("{id}")]
        public Model.DodatnaUsluga Update(int id, [FromBody]DodatneUslugeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.DodatnaUsluga GetById(int id)
        {
            return _service.GetById(id);
        }






    }
}