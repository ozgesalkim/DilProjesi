﻿using AutoMapper;
using DilProjesi.BLL.Abstact.Mapping;
using DilProjesi.BLL.Models.ProjeDto;
using DilProjesi.BLL.Models.TercumeDto;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Models.SozcukDto
{
    public class GetSozcukDto : BaseSozcukDto, IMapFrom
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Sozcuk, GetSozcukDto>().ReverseMap();
        }

        public virtual GetProjeDto Proje { get; set; }
        public virtual ICollection<GetTercumeDto> Tercumeler { get; set; }
    }
}
