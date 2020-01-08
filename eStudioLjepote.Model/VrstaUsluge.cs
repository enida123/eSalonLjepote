using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
   public class VrstaUsluge
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
    }
}
