using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Api.Domain.Models
{ 
    public class Locacao

{ 
    public int ? IdLocacao { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime DataFim { get; set; }


    public int ClienteId { get; set; }

     
    public Clientes Cliente{ get; set; }

    public int LocadoraId { get; set; }
      
     
     public Locadora Locadora { get; set; }


      public List<LocacaoCarro> LocacaoCarro { get; set; } 


    }
}
