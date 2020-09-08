using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface IProjeService
    {
        List<Proje> GetAll();
        List<Proje> GetById(int id);
        void Add(Proje entity);
        void Update(Proje entity);
        void Delete(Proje entity);
    }
}
