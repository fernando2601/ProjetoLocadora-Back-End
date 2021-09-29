using System;

namespace Api.Domain.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Renda { get; set; }
        public string Cpf { get; set; }
        public Locacao Locacao { get; set; }
    }
}
