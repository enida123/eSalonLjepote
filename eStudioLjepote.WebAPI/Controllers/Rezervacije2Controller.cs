using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.WebAPI.Database;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rezervacije2Controller : ControllerBase
    {
        private readonly IRezervacije2 _rezervacijaService;

        public Rezervacije2Controller(IRezervacije2 rezervacijaService)
        {
            _rezervacijaService = rezervacijaService;
        }
        [HttpGet]
        public List<Model.RezervacijaViewModel> Get()
        {

            return _rezervacijaService.Get();
        }
    }
}