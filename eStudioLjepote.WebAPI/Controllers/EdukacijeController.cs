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

    public class EdukacijeController : BaseCRUDController<Model.Edukacija, object, EdukacijeUpsertRequest, EdukacijeUpsertRequest>
    {
        public EdukacijeController(ICRUDService<Edukacija, object, EdukacijeUpsertRequest, EdukacijeUpsertRequest> service) : base(service)
        {
        }
    }
}