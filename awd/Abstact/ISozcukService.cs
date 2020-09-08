using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    interface ISozcukService
    {
        List<Sozcuk> GetAll();
        List<Sozcuk> GetById(int id);
        void Add(Sozcuk entity);
        void Update(Sozcuk entity);
        void Delete(Sozcuk entity);
    }
}
