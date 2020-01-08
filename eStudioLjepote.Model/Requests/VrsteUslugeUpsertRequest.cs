using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
    public  class VrsteUslugeUpsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
    }
}
