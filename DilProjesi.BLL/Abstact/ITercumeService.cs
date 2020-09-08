using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface ITercumeService
    {
        List<GetTercumeDto> GetAll();
        GetTercumeDto GetById(int id);
        bool Add (CreateTercumeDto model);
        bool Update (UpdateTercumeDto model);
        bool Delete(int id);
    }
}
    
