using DilProjesi.BLL.Models.ProjeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface IProjeService
    {
        List<GetProjeDto> GetAll();
        GetProjeDto GetById(int id);
        UpdateProjeDto GetByIdForUpdate(int id);
        bool Add(CreateProjeDto model);
        bool Update(UpdateProjeDto model);
        bool Delete(int id);
    }
}
