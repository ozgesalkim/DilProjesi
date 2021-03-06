﻿using AutoMapper;
using DilProjesi.BLL.Abstact;
using DilProjesi.BLL.Models.DilDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DilProjesi.BLL.Concrete
{
    public class DilManager : IDilService
    {
        private readonly IAppDbContext _context;
        private readonly IMapper _mapper;

        public DilManager(IAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool Add(CreateDilDto model)
        {
            var entity = _mapper.Map<Dil>(model);

            _context.Dil.Add(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false; ;
        }

        public bool Delete(int id)

        {
            var entity = _context.Dil.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return false;
            }

            _context.Dil.Remove(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }

        public List<GetDilDto> GetAll()
        {
            var entities = _context.Dil;

            var models = _mapper.Map<List<GetDilDto>>(entities);

            return models;
        }

        public GetDilDto GetById(int id)
        {
            var entity = _context.Dil.FirstOrDefault(x => x.Id == id);

            var model = _mapper.Map<GetDilDto>(entity);

            return model;
        }

        public UpdateDilDto GetByIdForUpdate(int id)
        {
            var entity = _context.Dil.FirstOrDefault(x => x.Id == id);

            var model = _mapper.Map<UpdateDilDto>(entity);

            return model;
        }

        public bool Update(UpdateDilDto model)
        {
            var entity = _mapper.Map<Dil>(model);

            _context.Dil.Update(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }
    }

       }
