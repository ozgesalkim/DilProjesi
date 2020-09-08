using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.ProjeDto
{
    public class UpdateProjeDto : BaseProjeDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proje, UpdateProjeDto>().ReverseMap();
        }
    }
}
