using DilProjesi.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.BLL.Abstact
{
    public interface IDbContext
    {
        public DbSet<Proje> Proje { get; set; }
        public DbSet<Sozcuk> Sozcuk { get; set; }
        public DbSet<Dil> Dil { get; set; }
        public DbSet<Tercume> Tercume { get; set; }
        int SaveChanges();
    }
}
