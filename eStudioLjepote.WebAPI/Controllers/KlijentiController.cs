using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Services_;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStudioLjepote.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class KlijentiController : ControllerBase
    {
        private readonly IKlijentiService _klijentiService;

        public KlijentiController(IKlijentiService klijentiService)
        {
            _klijentiService = klijentiService;
        }
        [HttpGet]
        public List<Model.Klijent> Get([FromQuery]KlijentiSearchRequest search)
        {

            return _klijentiService.Get(search);
        }
        [HttpGet("{id}")]
        public Model.Klijent GetById(int id)
        {
            return _klijentiService.GetById(id);
        }

        

        [HttpPost]
        public Model.Klijent Insert(KlijentiUpsertRequest request)
        {
            return _klijentiService.Insert(request);
        }
        [HttpPut("{Id}")]
        public Model.Klijent Update(int Id, [FromBody]KlijentiUpsertRequest request)
        {
            return _klijentiService.Update(Id, request);
        }
        
    }
}