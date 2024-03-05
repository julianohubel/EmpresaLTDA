using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Commands.Interfaces
{
    public interface ICommandResult
    {
        bool Sucesso { get; set; }
        string Mensagem { get; set; }
        object Dados { get; set; }
    }
}
