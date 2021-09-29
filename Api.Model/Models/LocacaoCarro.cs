using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Api.Domain.Models
{
    public class LocacaoCarro
    {
      
        public int IdCarro { get; set; }
        public int ? IdLocacao { get; set; }
        public double Preco { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime Renovacao { get; set; }

        public virtual Locacao Locacao { get; set; }
       
        public virtual Carros Carros { get; set; }
    }
}
