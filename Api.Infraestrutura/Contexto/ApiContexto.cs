using Api.Domain.Models;
using Api.Infraestrutura.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace Api.Infraestrutura.Contexto
{
    public class ApiContexto : DbContext
    {

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Carros> Carros { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Locadora> Locadoras { get; set; }
        public DbSet<LocacaoCarro> LocacoesCarros { get; set; }



        public ApiContexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /// Classes de mapeamento aqui...

            modelBuilder.ApplyConfiguration(new CarrosConfig());
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new LocacaoConfig());
            modelBuilder.ApplyConfiguration(new LocadoraConfig());
            modelBuilder.ApplyConfiguration(new LocacaoCarroConfig());
            base.OnModelCreating(modelBuilder);

        }
    }
}
