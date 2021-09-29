using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Domain.Models
{
    public class Locadora
    {
        public int IdLocadora { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }

        public List<Locacao> Locacoes { get; set; }

        public List<Carros> Carros { get; set; }
    }
}
