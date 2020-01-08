using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public interface IGradovi
    {
        List<Model.Grad> Get();
        Model.Grad GetById(int id);

    }
}
