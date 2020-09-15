using DilProjesi.BLL.Models.SozcukDto;
using DilProjesi.COMMON;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface ISozcukService
    {
        List<GetSozcukDto> GetAll();
        DataTableResponse<GetSozcukDto> LoadTable(DataTableRequest request);
        UpdateSozcukDto GetByIdForUpdate(int id);
        GetSozcukDto GetById(int id);
        bool Add(CreateSozcukDto model);
        bool Update(UpdateSozcukDto model);
        bool Delete(int id);
    }
}
