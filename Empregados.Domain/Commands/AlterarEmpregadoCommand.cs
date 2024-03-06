using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Commands
{
    public class AlterarEmpregadoCommand
    {
        public AlterarEmpregadoCommand(Guid id, string nome, string cargo, string departamento)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Departamento = departamento;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
    }
}
