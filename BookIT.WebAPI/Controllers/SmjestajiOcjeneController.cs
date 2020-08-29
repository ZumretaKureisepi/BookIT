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
    [Authorize]
    public class SmjestajiOcjeneController : ControllerBase
    {


        private readonly ISmjestajiOcjeneService _service;

        public SmjestajiOcjeneController(ISmjestajiOcjeneService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.SmjestajOcjena> Get([FromQuery]SmjestajiOcjeneSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("GetMyReviews")]
        public List<Model.SmjestajOcjena> GetMyReviews([FromQuery]SmjestajiOcjeneSearchRequest request)
        {
            return _service.GetMyReviews(request);
        }

        [Authorize(Roles = "Klijent")]
        [HttpPost]
        public Model.SmjestajOcjena Insert(SmjestajiOcjeneInsertRequest request)
        {
            return _service.Insert(request);
        }
        

        [HttpGet("{id}")]
        public Model.SmjestajOcjena GetById(int id)
        {
            return _service.GetById(id);
        }






    }
}