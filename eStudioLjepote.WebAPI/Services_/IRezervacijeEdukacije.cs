﻿using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public interface IRezervacijeEdukacije
    {
        List<Model.RezervacijaEdukacije> Get(RezervacijaEdukacijeSearch request);

    }
}
