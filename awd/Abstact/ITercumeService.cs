using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface ITercumeService
    {
        List<Tercume> GetAll();
        List<Tercume> GetById(int id);
        void Add(Tercume entity);
        void Update(Tercume entity);
        void Delete(Tercume entity);
    }
}
    
