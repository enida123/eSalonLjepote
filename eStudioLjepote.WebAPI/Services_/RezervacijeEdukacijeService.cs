using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eStudioLjepote.WebAPI.Services_
{
    public class RezervacijeEdukacijeService : IRezervacijeEdukacije
    {
        private readonly _150023Context context;
        private readonly IMapper _mapper;

        public RezervacijeEdukacijeService(_150023Context context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public List<Model.RezervacijaEdukacije> Get(RezervacijaEdukacijeSearch request)
        {
            var query = context.Set<Database.RezervacijaEdukacije>().AsQueryable();

            if (request?.EdukacijaId.HasValue == true)
            {
                query = query.Where(x => x.EdukacijaId == request.EdukacijaId);
            }

            var list = query.Include(x=>x.Klijent).Include(y=>y.Edukacija).ToList();
            
            List<Model.RezervacijaEdukacije> model = list.Select(x => new Model.RezervacijaEdukacije
            {
                Id = x.Id,
                Klijent=x.Klijent.Ime+" "+x.Klijent.Prezime,
                Edukacija=x.Edukacija.Naziv



            }).ToList();

            return model;

        }
    }
}
