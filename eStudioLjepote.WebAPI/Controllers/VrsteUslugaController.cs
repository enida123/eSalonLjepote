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
   
    public class VrsteUslugaController : BaseCRUDController<Model.VrstaUsluge, object, VrsteUslugeUpsertRequest, VrsteUslugeUpsertRequest>
    {
        public VrsteUslugaController(ICRUDService<VrstaUsluge, object, VrsteUslugeUpsertRequest, VrsteUslugeUpsertRequest> service) : base(service)
        {
        }
    }
}