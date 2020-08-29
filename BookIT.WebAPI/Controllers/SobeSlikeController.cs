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
    public class SobeSlikeController : ControllerBase
    {

        private readonly ISobeSlikeService _service;

        public SobeSlikeController(ISobeSlikeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.SobaSlika> Get([FromQuery]SobeSlikeSearchRequest request)
        {
            return _service.Get(request);
        }
   

        [Authorize(Roles = "Vlasnik smještaja")]
        [HttpPost]
        public Model.SobaSlika Insert(SobeSlikeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Vlasnik smještaja")]
        [HttpPut("{id}")]
        public Model.SobaSlika Update(int id, [FromBody]SobeSlikeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.SobaSlika GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("GetSobeSlika/{SobaId}")]
        public Model.SobaSlika GetSobeSlika(int SobaId)
        {
            return _service.GetSobeSlika(SobaId);
        }




    }
}