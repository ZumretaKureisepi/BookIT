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
    public class DrzaveController : ControllerBase
    {
        private readonly IDrzaveService _service;

        public DrzaveController(IDrzaveService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        [HttpGet]
        public List<Model.Drzava> Get()
        {
            return _service.Get();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Drzava Insert(DrzaveInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}