using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Entities
{
    public class Empresa
    {
        public Empresa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
