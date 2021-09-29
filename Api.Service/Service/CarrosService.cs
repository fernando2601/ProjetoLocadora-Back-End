using Api.Domain.Models;
using Api.Infraestrutura.Interface;
using Api.Service.Interface;
using System;

namespace Api.Service
{
    public class CarrosService : BaseService<Carros>, ICarrosService
    {
        public CarrosService(IBaseRepositorio<Carros> db) : base(db)
        {

        }
    }
}
