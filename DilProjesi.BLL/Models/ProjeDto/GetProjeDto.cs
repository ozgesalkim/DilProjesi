using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.SozcukDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.ProjeDto
{
    public class GetProjeDto : BaseProjeDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proje, GetProjeDto>().ReverseMap();
        }

        public virtual ICollection<GetSozcukDto> Sozcukler { get; set; }
    }
}
