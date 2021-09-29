using Api.Domain.Models;
using Api.Infraestrutura.Contexto;
using Api.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infraestrutura.Repositorio
{
    public class CarrosRepositorio : BaseRepositorio<Carros>, ICarrosRepositorio
    {
        public CarrosRepositorio(ApiContexto apiContexto) : base(apiContexto)
        {
                
        }
    }
}
