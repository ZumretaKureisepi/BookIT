using System;
using System.Collections.Generic;
using BookIT.WebAPI.Database;
using BookIT.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookIT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Klijent")]
    [ApiController]
    public class PreporukaController : ControllerBase
    {
        private IPreporukaService _service;

        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Smjestaj> RecommentMovies()
        {
            return _service.PreporuciSmjestaje();
        }
    }
}