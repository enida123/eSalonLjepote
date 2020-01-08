using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eStudioLjepote.Model.Requests
{
   public class UslugeUpsertRequest
    {

        [Required]
        public float Cijena { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public string KratkiOpis { get; set; }
        public byte[] ImageThumbnail { get; set; }

        public int VrstaUslugeId { get; set; }

    }
}
