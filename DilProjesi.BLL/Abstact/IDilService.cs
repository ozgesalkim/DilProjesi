using DilProjesi.BLL.Models.DilDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface IDilService
    {
        List<GetDilDto> GetAll();
        GetDilDto GetById(int id);
        UpdateDilDto GetByIdForUpdate(int id);
        bool Add(CreateDilDto model);
        bool Update(UpdateDilDto model);
        bool Delete(int id);
    }
}
