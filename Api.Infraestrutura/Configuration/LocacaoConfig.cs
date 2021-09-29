using Api.Domain.Models;
using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Configuration
{
    public class LocacaoConfig : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.HasKey(l => l.IdLocacao);

            builder
                .Property(l => l.DataFim)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(l => l.DataInicio)
                .IsRequired()
                .HasMaxLength(50);


            builder
               .HasOne(l => l.Locadora).WithMany(lc => lc.Locacoes).HasForeignKey(l => l.LocadoraId);


            builder
                .HasOne(l => l.Cliente).WithOne(c => c.Locacao).HasForeignKey<Locacao>(c=>c.ClienteId);


            


        }
    }
}