using Api.Domain.Models;
using Api.Infraestrutura.Contexto;
using Api.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Repositorio
{
    public class LocacaoRepositorio : BaseRepositorio<Locacao>, ILocacaoRepositorio
    {
        public LocacaoRepositorio(ApiContexto apiContexto) : base(apiContexto)
        {

        }
    }
}
