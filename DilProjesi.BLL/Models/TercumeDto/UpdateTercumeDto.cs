using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.TercumeDto
{
    public class UpdateTercumeDto:BaseTercumeDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Tercume, UpdateTercumeDto>().ReverseMap();
        }
    }
}
