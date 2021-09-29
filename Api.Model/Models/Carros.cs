using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Api.Domain.Models
{
    public class Carros
    {
        public int IdCarro { get; set; }

        public string Nome { get; set; }

        public string Placa { get; set; }

        public int Ano { get; set; }

        public int IdLocadora { get; set; }
        
        public Locadora Locadora { get; set; }
        public List<LocacaoCarro> LocacaoCarro { get; set; }


    }
}
