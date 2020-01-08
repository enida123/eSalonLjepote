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
    public class Plata2Service : IPlate2
    {
        private readonly _150023Context _context;
        private readonly IMapper _mapper;

        public Plata2Service(_150023Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<PlataViewModel> Get(PlataSearchRequest request)
        {
            var query = _context.Set<Database.Plata>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Godina))
            {
                query = query.Where(x => x.Godina.ToString() == request.Godina);
            }
            if (!string.IsNullOrWhiteSpace(request?.Mjesec))
            {
                query = query.Where(x => x.Mjesec.ToString() == request.Mjesec);
            }



            var list = query.Include(z => z.Zaposlenik).ToList();

            List<PlataViewModel> model = list.Select(x => new PlataViewModel
            {
                Id = x.Id,


                Datum = x.Datum.ToShortDateString(),
              
                Iznos = x.Iznos,
                Godina = x.Godina,
                Mjesec=x.Mjesec,
                Zaposlenik = x.Zaposlenik.Ime + " " + x.Zaposlenik.Prezime


            }).ToList();

            return model;
        }
    }
}
