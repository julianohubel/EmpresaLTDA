using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Commands
{
    public class ExcluirEmpregadoCommand
    {

        public ExcluirEmpregadoCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}
