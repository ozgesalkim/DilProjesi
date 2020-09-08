using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.DilDto
{
    public class GetDilDto : BaseDilDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Dil, GetDilDto>().ReverseMap();
        }

        public virtual ICollection<GetTercumeDto> Tercumeler { get; set; }
    }
}
