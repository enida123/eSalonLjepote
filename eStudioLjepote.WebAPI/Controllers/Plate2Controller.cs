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
    public class Plate2Controller : ControllerBase
    {
        private readonly IPlate2 _plate;

        public Plate2Controller(IPlate2 plate)
        {
            _plate = plate;
        }

        [HttpGet]
        public List<Model.PlataViewModel> Get([FromQuery]PlataSearchRequest search)
        {

            return _plate.Get(search);
        }
    }
}