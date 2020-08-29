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
    [Route("api/[controller]")]
    [ApiController]
    public class SmjestajiSlikeController : ControllerBase
    {

        private readonly ISmjestajiSlikeService _service;

        public SmjestajiSlikeController(ISmjestajiSlikeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.SmjestajSlika> Get([FromQuery]SmjestajiSlikeSearchRequest request)
        {
            return _service.Get(request);
        }
   

        [Authorize(Roles = "Vlasnik smještaja")]
        [HttpPost]
        public Model.SmjestajSlika Insert(SmjestajiSlikeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Vlasnik smještaja")]
        [HttpPut("{id}")]
        public Model.SmjestajSlika Update(int id, [FromBody]SmjestajiSlikeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.SmjestajSlika GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet("GetSmjestajSlika/{SmjestajId}")]
        public Model.SmjestajSlika GetSmjestajSlika(int SmjestajId)
        {
            return _service.GetSmjestajSlika(SmjestajId);
        }




    }
}