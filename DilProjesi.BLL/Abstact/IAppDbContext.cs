using DilProjesi.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface IAppDbContext
    {
        DbSet<Proje> Proje { get; set; }
        DbSet<Sozcuk> Sozcuk { get; set; }
        DbSet<Dil> Dil { get; set; }
        DbSet<Tercume> Tercume { get; set; }
    }
}
