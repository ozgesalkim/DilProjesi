using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface IDilService
    {
        List<Dil> GetAll();
        List<Dil> GetById(int id);
        void Add(Dil entity);
        void Update(Dil entity);
        void Delete(Dil entity);
    }
}
