using DilProjesi.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DAL.Configurations
{
    public class ProjeConfiguration : IEntityTypeConfiguration<Proje>
    {
        public void Configure(EntityTypeBuilder<Proje> builder)
        {
            builder.ToTable(typeof(Proje).Name);

            builder.Property(e => e.Ad)
            .IsRequired()
            .HasMaxLength(200);

            builder
            .HasMany(d => d.Sozcukler);
        }
    }
}
