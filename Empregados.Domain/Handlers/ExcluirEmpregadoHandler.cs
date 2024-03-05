using Empregados.Domain.Commands;
using Empregados.Domain.Commands.Interfaces;
using Empregados.Domain.Commands.Results;
using Empregados.Domain.Handlers.Interfaces;
using Empregados.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Handlers
{
    public class ExcluirEmpregadoHandler : IExcluirEmpregadoHandler
    {
        private readonly IEmpregadoRepository _repository;

        public ExcluirEmpregadoHandler(IEmpregadoRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(ExcluirEmpregadoCommand command)
        {
            var empregado = _repository.RecuperarPorId(command.Id);

            if (empregado == null)
                return null;

            empregado.Excluir();


            //Como a exclusão é logica, só alteramos o registro na BD
            _repository.Alterar(empregado);

            return new CommandResult(true, "Empregado excluido com sucesso", empregado);
        }
    }
}
