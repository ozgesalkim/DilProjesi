using DilProjesi.BLL.Abstact;
using DilProjesi.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DAL
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Proje> Proje { get; set; }
        public DbSet<Sozcuk> Sozcuk { get; set; }
        public DbSet<Dil> Dil { get; set; }
        public DbSet<Tercume> Tercume { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
