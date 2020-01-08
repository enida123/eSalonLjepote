using AutoMapper;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public class VrstaProoizvodaService : BaseCRUDService<Model.VrsteProizvoda, object, Database.VrstaProizvoda, VrsteProizvodaUpsert, VrsteProizvodaUpsert>
    {
        public VrstaProoizvodaService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
