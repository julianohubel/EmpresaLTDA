using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Entities
{
    public class Empregado
    {

        public Empregado(string nome, string cargo, string departamento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cargo = cargo;
            Departamento = departamento;
        }

        public Guid Id { get; set; }        
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public bool Excluido { get; set; }

        public void AlterarDados(string nome, string cargo, string departamento)
        {
            Nome = nome;
            Cargo = cargo;
            Departamento = departamento;
        }

        public void Excluir()
        {
            Excluido = true;
        }

    }    
}
