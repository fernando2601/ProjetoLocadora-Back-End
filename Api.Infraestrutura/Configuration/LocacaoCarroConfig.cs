using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Configuration
{
    public class LocacaoCarroConfig : IEntityTypeConfiguration<LocacaoCarro>
    {
        public void Configure(EntityTypeBuilder<LocacaoCarro> builder)
        {
            builder.HasKey(l => new { l.IdCarro, l.IdLocacao});

            builder
                .Property(l => l.DataFim)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(l => l.DataInicio)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(l => l.Preco)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(l => l.Renovacao)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .HasOne(lc => lc.Carros)
                .WithMany(c => c.LocacaoCarro)
                .HasForeignKey(lc => lc.IdCarro)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(lc => lc.Locacao)
                .WithMany(l => l.LocacaoCarro)
                .HasForeignKey(lc => lc.IdLocacao)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_LocacoesCarros_Locacao_IdLocacao");
                   
        }
               
    }
}
