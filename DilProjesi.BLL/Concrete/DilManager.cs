using DilProjesi.BLL.Abstact;
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

        public DilManager(IAppDbContext context)
        {
            _context = context;
        }

        public void Add(Dil entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Dil entity)
        {
            throw new NotImplementedException();
        }

        public List<Dil> GetAll()
        {
            return _context.Dil.ToList();
        }

        public List<Dil> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Dil entity)
        {
            throw new NotImplementedException();
        }
    }
}
