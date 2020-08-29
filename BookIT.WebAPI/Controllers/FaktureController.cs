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
    public class FaktureController : ControllerBase
    {

        private readonly IFaktureService _service;

        public FaktureController(IFaktureService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Faktura> Get([FromQuery]FaktureSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Faktura GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Faktura Insert(FaktureInsertRequest request)
        {
            return _service.Insert(request);
        }


    }
}