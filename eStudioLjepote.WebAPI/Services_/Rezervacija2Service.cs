using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eStudioLjepote.WebAPI.Services_
{
    public class Rezervacija2Service : IRezervacije2
    {
        private readonly _150023Context _context;
        private readonly IMapper _mapper;

        public Rezervacija2Service(_150023Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<RezervacijaViewModel> Get()
        {
            var list = _context.Set<Database.Rezervacija>().Include(y => y.Klijent).Include(y => y.Usluge)
                 .ToList();
            List<RezervacijaViewModel> model = list.Select(x => new RezervacijaViewModel
            {
                Id = x.Id,
                BrojOsoba=x.BrojOsoba,
                Klijent=x.Klijent.Ime+" "+ x.Klijent.Prezime,
                Usluge=x.Usluge.Naziv,
                Vrijeme=x.Vrijeme,
                DatumRezervacije = x.DatumRezervacije.ToShortDateString(),
               Otkazana=x.Otkazano,
               Prihvacena=x.Prihvaceno,
               Status=x.Status,
               Napomena=x.Napomena



            }).ToList();

            return model;
        }
    }
}
