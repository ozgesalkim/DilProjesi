using DilProjesi.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilProjesi.DAL.Configurations
{
    public class TercumeConfiguration : IEntityTypeConfiguration<Tercume>
    {
        public void Configure(EntityTypeBuilder<Tercume> builder)
        {
            builder.ToTable(typeof(Tercume).Name);

            builder.Property(e => e.Ceviri)
            .IsRequired()      
            .HasMaxLength(200);

            builder
            .HasOne(e => e.Sozcuk)
            .WithMany(e => e.Tercumeler)
            .HasForeignKey(e => e.FkSozcukId);

            builder
            .HasOne(e => e.Dil)
            .WithMany(e => e.Tercumeler)
            .HasForeignKey(e => e.FkDilId);
        }
    }
}
