using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookIT.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookIT.WebAPI.Controllers
{   [Authorize(Roles ="Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : ControllerBase
    {

        private readonly IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Uloga> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public Model.Uloga GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}