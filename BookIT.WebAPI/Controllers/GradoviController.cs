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
    public class GradoviController : ControllerBase
    {
        private readonly IGradoviService _service;

        public GradoviController(IGradoviService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        [HttpGet]
        public List<Model.Grad> Get([FromQuery]GradoviSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize(Roles ="Administrator")]
        [HttpPost]
        public Model.Grad Insert(GradoviInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles ="Administrator")]
        [HttpPut("{id}")]
        public Model.Grad Update(int id, [FromBody]GradoviInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Grad GetById(int id)
        {
            return _service.GetById(id);
        }



    }
}