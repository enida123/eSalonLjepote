﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
    public  class RezervacijeUpdateRequest
    {
        public bool Prihvaceno { get; set; }
        public bool Otkazano { get; set; }
        public string Status { get; set; }
        public string Napomena { get; set; }


    }
}
