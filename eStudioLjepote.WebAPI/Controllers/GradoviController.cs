using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

    public class GradoviController : ControllerBase
    {
        private readonly IGradovi _GradoviService;

        public GradoviController(IGradovi GradoviService)
        {
            _GradoviService = GradoviService;
        }

        [HttpGet]
        public List<Model.Grad> Get()
        {

            return _GradoviService.Get();
        }
        [HttpGet("{id}")]
        public Model.Grad GetById(int id)
        {
            return _GradoviService.GetById(id);
        }

    }
}