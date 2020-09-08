using DilProjesi.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DAL.Configurations
{
    public class SozcukConfiguration : IEntityTypeConfiguration<Sozcuk>
    {
        public void Configure(EntityTypeBuilder<Sozcuk> builder)
        {
            builder.ToTable(typeof(Sozcuk).Name);

            builder.Property(e => e.Ad)
            .IsRequired()
            .HasMaxLength(200);

            builder
            .HasMany(e => e.Tercumeler);

            builder
            .HasOne(e => e.Proje)
            .WithMany(e => e.Sozcukler)
            .HasForeignKey(e => e.FkProjeId);
        }
    }
}
