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
    public class SobeController : ControllerBase
    {

        private readonly ISobeService _service;

        public SobeController(ISobeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Soba> Get([FromQuery]SobeSearchRequest request)
        {
            return _service.Get(request);
        }
        [Authorize(Roles ="Vlasnik smještaja")]
        [HttpPost]
        public Model.Soba Insert(SobeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles ="Vlasnik smještaja")]
        [HttpPut("{id}")]
        public Model.Soba Update(int id, [FromBody]SobeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Soba GetById(int id)
        {
            return _service.GetById(id);
        }





    }
}