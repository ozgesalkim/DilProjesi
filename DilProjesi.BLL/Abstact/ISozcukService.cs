using DilProjesi.BLL.Models.SozcukDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    interface ISozcukService
    {
        List<GetSozcukDto> GetAll();
        GetSozcukDto GetById(int id);
        bool Add(CreateSozcukDto model);
        bool Update(UpdateSozcukDto model);
        bool Delete(int id);
    }
}
