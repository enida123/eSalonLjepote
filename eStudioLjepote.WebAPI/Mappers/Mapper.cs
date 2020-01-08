using AutoMapper;
using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Zaposlenik, Model.Zaposlenik>();
            CreateMap<Database.RezervacijaEdukacije, Model.RezervacijaEdukacije>();

            CreateMap<Database.Zaposlenik, ZaposleniciInsertRequest>().ReverseMap();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.VrstaProizvoda, Model.VrsteProizvoda>();
            CreateMap<Database.Proizvods, ProizvodUpsertRequest>().ReverseMap();
            CreateMap<Database.Klijent, KlijentiUpsertRequest>().ReverseMap();
            CreateMap<Database.Usluge, UslugeUpsertRequest>().ReverseMap();
            CreateMap<Database.Uplate, UplateUpsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Rezervacija>().ReverseMap();
            CreateMap<Database.Rezervacija, RezervacijeUpdateRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Database.Ratings, OcjeneUpsertRequest>().ReverseMap();

            CreateMap<Database.Plata, PlataUpsertRequest>().ReverseMap();
            CreateMap<Database.VrstaUsluge, VrsteUslugeUpsertRequest>().ReverseMap();
            CreateMap<Database.VrstaProizvoda, VrsteProizvodaUpsert>().ReverseMap();
            CreateMap<Database.Edukacija, EdukacijeUpsertRequest>().ReverseMap();


        }
    }
}
