using DilProjesi.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DAL.Configurations
{
    public class DilConfiguration : IEntityTypeConfiguration<Dil>
    {
        public void Configure(EntityTypeBuilder<Dil> builder)
        {
            builder.ToTable(typeof(Dil).Name);

            builder.Property(e => e.Ad)
            .IsRequired()
            .HasMaxLength(200);

            builder.Property(e => e.Anahtar)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(e => e.Aciklama)
            .HasMaxLength(400);

            builder
            .HasMany(d => d.Tercumeler);
        }
    }
}
