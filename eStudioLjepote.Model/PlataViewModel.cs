using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model
{
    public class PlataViewModel
    {
        public int Id { get; set; }
        public decimal Iznos { get; set; }
        public string Zaposlenik { get; set; }
        public string Datum { get; set; }
        public int Godina { get; set; }
        public int Mjesec { get; set; }
    }
}
