using System;
using System.Collections.Generic;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
   public  class EdukacijeUpsertRequest
    {
        public float Cijena { get; set; }
        public DateTime Kraj { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime Pocetak { get; set; }
        public int ZaposlenikId { get; set; }
        public int BrojUcesnika { get; set; }
        public int BrojPrijavljenih { get; set; }
    }
}
