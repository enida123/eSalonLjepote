using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public interface IRezervacije2
    {
        List<Model.RezervacijaViewModel> Get();
    }
}
