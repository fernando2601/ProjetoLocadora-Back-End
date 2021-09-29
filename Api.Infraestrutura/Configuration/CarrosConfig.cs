using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Configuration
{
    public class CarrosConfig : IEntityTypeConfiguration<Carros>
    {
        public void Configure(EntityTypeBuilder<Carros> builder)
        {
            builder.HasKey(c => c.IdCarro);

            builder
                .Property(c => c.Ano)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(c => c.Placa)
                .IsRequired()
                .HasMaxLength(11);

            
             builder
                .HasOne(c => c.Locadora).WithMany(l=>l.Carros).HasForeignKey(c=>c.IdLocadora);
            
        }
    }
}
