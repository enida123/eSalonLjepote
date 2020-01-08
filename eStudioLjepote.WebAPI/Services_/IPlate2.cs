using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public interface IPlate2
    {
        List<Model.PlataViewModel> Get(PlataSearchRequest request);

    }
}
