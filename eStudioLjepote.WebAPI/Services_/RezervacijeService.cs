using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.Model.Requests;
using eStudioLjepote.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStudioLjepote.WebAPI.Services_
{
    public class RezervacijeService : BaseCRUDService<Model.Rezervacija, RezervacijeSearchRequest, Database.Rezervacija, RezervacijaInsertRequest, RezervacijeUpdateRequest>
    {
        public RezervacijeService(_150023Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Rezervacija> Get(RezervacijeSearchRequest search)
        {
            var query = _context.Set<Database.Rezervacija>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Godina))
            {
               query = query.Where(x => x.DatumRezervacije.Year.ToString()== search.Godina);
            }
            if (!string.IsNullOrWhiteSpace(search?.Mjesec))
            {
                query = query.Where(x => x.DatumRezervacije.Month.ToString() == search.Mjesec);
            }
            if (!string.IsNullOrWhiteSpace(search?.Dan))
            {
                query = query.Where(x => x.DatumRezervacije.Day.ToString() == search.Dan);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Rezervacija>>(list);



        }

    }
}
