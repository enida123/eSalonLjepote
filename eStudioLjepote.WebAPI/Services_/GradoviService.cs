using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eStudioLjepote.Model;
using eStudioLjepote.WebAPI.Database;

namespace eStudioLjepote.WebAPI.Services_
{
    public class GradoviService : IGradovi
    {

        private readonly _150023Context _context;
        private readonly IMapper _mapper;

        public GradoviService(_150023Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        List<Model.Grad> IGradovi.Get()
        {
            var list = _context.Set<Database.Grad>().ToList();
            return _mapper.Map<List<Model.Grad>>(list);
        }
        public Model.Grad GetById(int id)
        {
            var entity = _context.Grad.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<Model.Grad>(entity);
        }

    }
}
