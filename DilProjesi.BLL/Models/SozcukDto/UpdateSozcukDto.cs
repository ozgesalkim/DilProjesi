using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.SozcukDto
{
    public class UpdateSozcukDto:BaseSozcukDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sozcuk, UpdateSozcukDto>().ReverseMap();
        }
    }
}
