using System;
using System.Collections.Generic;

namespace eStudioLjepote.Model
{
   public  class UplateViewModel
    {
        public int Id { get; set; }
        public float Iznos { get; set; }
        public string DatumRezervacije { get; set; }
        public string tipUplate { get; set; }
        public string DatumUplate { get; set; }
        public float Popust { get; set; }
        public string Zaposlenik { get; set; }


    }
}
