using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStudioLjepote.WebAPI.Database;
using AutoMapper;

namespace eStudioLjepote.WebAPI.Services_
{
    public class EdukacijaService : BaseCRUDService<Model.Edukacija, object, Edukacija, EdukacijeUpsertRequest, EdukacijeUpsertRequest>
    {
        public EdukacijaService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
