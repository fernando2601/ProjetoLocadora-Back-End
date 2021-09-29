using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Configuration
{
    public class LocadoraConfig : IEntityTypeConfiguration<Locadora>
    {
        public void Configure(EntityTypeBuilder<Locadora> builder)
        {
            builder.HasKey(l => l.IdLocadora);

            builder
                .Property(l => l.Endereco)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(l => l.Cep)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(l => l.Cnpj)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(l => l.Carros)
                .WithOne(c => c.Locadora).HasForeignKey(l => l.IdCarro);
        }
    }
}


















































