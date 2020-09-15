using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.SozcukDto
{
    public class CreateSozcukDto : BaseSozcukDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sozcuk, CreateSozcukDto>().ReverseMap();
        }

        public virtual ICollection<GetTercumeDto> Tercumeler { get; set; }
    }
}
