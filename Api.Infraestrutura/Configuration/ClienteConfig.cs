using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(c => c.Endereco)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(c => c.Renda)
                .IsRequired()
                .HasMaxLength(20);


        }

    }
}
