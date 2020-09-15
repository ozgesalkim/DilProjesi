using AutoMapper;
using DilProjesi.BLL.Abstact;
using DilProjesi.BLL.Models.ProjeDto;
using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DilProjesi.BLL.Concrete
{
    public class TercumeManager : ITercumeService
    {
        private readonly IAppDbContext _context;
        private readonly IMapper _mapper;

        public TercumeManager(IAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool Add(CreateTercumeDto model)
        {
            var entity = _mapper.Map<Tercume>(model);

            _context.Tercume.Add(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            var entity = _context.Tercume.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return false;
            }

            _context.Tercume.Remove(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }

        public List<GetTercumeDto> GetAll()
        {
            var entities = _context.Tercume;

            var models = _mapper.Map<List<GetTercumeDto>>(entities);

            return models;
        }

        public GetTercumeDto GetById(int id)
        {
            var entity = _context.Tercume.FirstOrDefault(x => x.Id == id);

            var model = _mapper.Map<GetTercumeDto>(entity);

            return model;
        }

        public bool Update(UpdateTercumeDto model)
        {
            var entity = _mapper.Map<Tercume>(model);

            _context.Tercume.Update(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }
    }

}