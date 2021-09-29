using Api.Domain.Models;
using Api.Infraestrutura.Contexto;
using Api.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Repositorio
{
    public class LocadoraRepositorio : BaseRepositorio<Locadora>, ILocadoraRepositorio
    {
        public LocadoraRepositorio(ApiContexto apiContexto) : base(apiContexto)
        {

        }
    }
}
