using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.DilDto
{
    public class CreateDilDto:BaseDilDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Dil, CreateDilDto>().ReverseMap();
        }
    }
}
