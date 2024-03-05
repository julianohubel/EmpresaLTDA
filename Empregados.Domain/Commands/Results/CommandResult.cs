using Empregados.Domain.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Commands.Results
{
    public class CommandResult : ICommandResult
    {
        public CommandResult(bool sucesso, string messagem, object dados)
        {
            Sucesso = sucesso;
            Mensagem = messagem;
            Dados = dados;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Dados { get; set; }
    }
}
