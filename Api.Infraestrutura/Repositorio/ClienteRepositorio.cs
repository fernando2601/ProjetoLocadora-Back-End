using Api.Domain.Models;
using Api.Infraestrutura.Contexto;
using Api.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Clientes>, IClienteRepositorio
    {
        public ClienteRepositorio(ApiContexto apiContexto) : base(apiContexto)
        {

        }
    }
}
