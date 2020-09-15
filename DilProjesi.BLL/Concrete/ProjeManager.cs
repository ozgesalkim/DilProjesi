using AutoMapper;
using DilProjesi.BLL.Abstact;
using DilProjesi.BLL.Models.ProjeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DilProjesi.BLL.Concrete
{
    public class ProjeManager : IProjeService
    {
        private readonly IAppDbContext _context;
        private readonly IMapper _mapper;

        public ProjeManager(IAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Add(CreateProjeDto model)
        {
            var entity = _mapper.Map<Proje>(model);

            _context.Proje.Add(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            var entity = _context.Proje.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return false;
            }

            _context.Proje.Remove(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }

        public List<GetProjeDto> GetAll()
        {
            var entities = _context.Proje.ToList();

            var models = _mapper.Map<List<GetProjeDto>>(entities);

            return models;
        }

        public GetProjeDto GetById(int id)
        {
            var entity = _context.Proje.FirstOrDefault(x => x.Id == id);

            var model = _mapper.Map<GetProjeDto>(entity);

            return model;
        }

        public UpdateProjeDto GetByIdForUpdate(int id)
        {
            var entity = _context.Proje.FirstOrDefault(x => x.Id == id);

            var model = _mapper.Map<UpdateProjeDto>(entity);

            return model;
        }

        public bool Update(UpdateProjeDto model)
        {
            var entity = _mapper.Map<Proje>(model);

            _context.Proje.Update(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }
    }
}
