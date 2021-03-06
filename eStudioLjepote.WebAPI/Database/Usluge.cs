﻿using System;
using System.Collections.Generic;

namespace eStudioLjepote.WebAPI.Database
{
    public partial class Usluge
    {
        public Usluge()
        {
            ProizvodUsluga = new HashSet<ProizvodUsluga>();
            PruzeneUsluge = new HashSet<PruzeneUsluge>();
            Ratings = new HashSet<Ratings>();
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int Id { get; set; }
        public float Cijena { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] ImageThumbnail { get; set; }
        public int? VrstaUslugeId { get; set; }
        public string KratkiOpis { get; set; }

        public virtual VrstaUsluge VrstaUsluge { get; set; }
        public virtual ICollection<ProizvodUsluga> ProizvodUsluga { get; set; }
        public virtual ICollection<PruzeneUsluge> PruzeneUsluge { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
