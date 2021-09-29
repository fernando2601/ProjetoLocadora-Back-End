using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Service
{
    public class ClienteService : BaseService<Clientes>, IClienteService
    {
        public ClienteService(IBaseRepositorio<Clientes> db) : base(db)
        {

        }
    }
}
