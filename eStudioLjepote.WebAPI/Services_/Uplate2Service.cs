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
    public class Uplate2Service : IUplate2
    {
        private readonly _150023Context _context;
        private readonly IMapper _mapper;

        public Uplate2Service(_150023Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.UplateViewModel> Get(UplateSearchRequest searchRequest)
        {

            var query = _context.Set<Database.Uplate>().AsQueryable();


            if (!string.IsNullOrWhiteSpace(searchRequest?.Godina))
            {
                query = query.Where(x => x.DatumUplate.Year.ToString() == searchRequest.Godina);
            }
            if (!string.IsNullOrWhiteSpace(searchRequest?.Mjesec))
            {
                query = query.Where(x => x.DatumUplate.Month.ToString() == searchRequest.Mjesec);
            }
            if (!string.IsNullOrWhiteSpace(searchRequest?.Dan))
            {
                query = query.Where(x => x.DatumUplate.Day.ToString() == searchRequest.Dan);
            }



            var list = query.Include(x => x.Rezervacija).Include(y => y.TipUplate).Include(z=>z.Zaposlenik).ToList();




            List<UplateViewModel> model= list.Select(x => new UplateViewModel
            {
                Id = x.Id,


                DatumUplate = x.DatumUplate.ToShortDateString(),
                tipUplate = x.TipUplate.Naziv,
                DatumRezervacije = x.Rezervacija.DatumRezervacije.ToShortDateString(),
                Iznos = x.Iznos,
                Popust = x.Popust,
                Zaposlenik=x.Zaposlenik.Ime+" "+x.Zaposlenik.Prezime


            }).ToList();

            return model;
        }
    }
}
