using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Service
{
    public class LocacaoService : BaseService<Locacao>, ILocacaoService
    {
        public LocacaoService(IBaseRepositorio<Locacao> db) : base(db)
        {
        }
    }
}
