using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
    public class RezervacijaViewModel
    {
        public int Id { get; set; }
        public string Klijent { get; set; }
        public int BrojOsoba { get; set; }
        public string Usluge { get; set; }
        public string DatumRezervacije { get; set; }
        public string Vrijeme { get; set; }
        public bool Prihvacena { get; set; }
        public bool Otkazana { get; set; }
        public string Status { get; set; }
        public string Napomena { get; set; }


    }
}
