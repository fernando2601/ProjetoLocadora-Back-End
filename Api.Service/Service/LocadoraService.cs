using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Service.Service
{
    public class LocadoraService : BaseService<Locadora>, ILocadoraService
    {
        public LocadoraService(IBaseRepositorio<Locadora> db) : base(db)
        {
        }
    }
}
