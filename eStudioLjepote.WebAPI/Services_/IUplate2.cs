using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
   public  interface IUplate2
    {
        List<Model.UplateViewModel> Get(UplateSearchRequest searchRequest);
       
    }
}
