using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Uplate2Controller : ControllerBase
    {
        private readonly IUplate2 _uplateService;

        public Uplate2Controller(IUplate2 uplateService)
        {
            _uplateService = uplateService;
        }
        [HttpGet]
        public List<Model.UplateViewModel> Get([FromQuery]UplateSearchRequest search)
        {
            return _uplateService.Get(search);
        }
    }
}