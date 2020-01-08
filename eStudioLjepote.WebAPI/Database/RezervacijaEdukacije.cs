using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database
{
    public partial class RezervacijaEdukacije
    {
        public int Id { get; set; }
        public int EdukacijaId { get; set; }
        public int KlijentId { get; set; }

        public virtual Edukacija Edukacija { get; set; }
        public virtual Klijent Klijent { get; set; }
    }
}
