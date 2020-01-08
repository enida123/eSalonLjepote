using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RezervacijaEdukacijeController : ControllerBase
    {
        private readonly IRezervacijeEdukacije _service;

        public RezervacijaEdukacijeController(IRezervacijeEdukacije service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.RezervacijaEdukacije> Get([FromQuery]RezervacijaEdukacijeSearch search)
        {

            return _service.Get(search);
        }
    }
}