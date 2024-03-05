using Empregados.Domain.Commands;
using Empregados.Domain.Commands.Interfaces;
using Empregados.Domain.Commands.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Handlers.Interfaces
{
    public interface IExcluirEmpregadoHandler
    {

        ICommandResult Handle(ExcluirEmpregadoCommand command);
        
    }
}
