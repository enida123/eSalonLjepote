using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database
{
    public partial class VrstaUsluge
    {
        public VrstaUsluge()
        {
            Usluge = new HashSet<Usluge>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Usluge> Usluge { get; set; }
    }
}
