using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.DilDto;
using DilProjesi.BLL.Models.SozcukDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.TercumeDto
{
    public class GetTercumeDto : BaseTercumeDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Tercume, GetTercumeDto>().ReverseMap();
        }

        public virtual GetDilDto Dil { get; set; }
        public virtual GetSozcukDto Sozcuk { get; set; }
    }
}
