using AutoMapper;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public class VrstaUslugeService : BaseCRUDService<Model.VrstaUsluge, object, Database.VrstaUsluge, VrsteUslugeUpsertRequest, VrsteUslugeUpsertRequest>
    {
        public VrstaUslugeService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
