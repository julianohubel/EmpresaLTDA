using Empregados.Domain.Commands;
using Empregados.Domain.Commands.Interfaces;
using Empregados.Domain.Commands.Results;
using Empregados.Domain.Handlers.Interfaces;
using Empregados.Domain.Repositories;

namespace Empregados.Domain.Handlers
{
    public class AlterarEmpregadoHandler : IAlterarEmpregadoHandler
    {
        private readonly IEmpregadoRepository _repository;

        public AlterarEmpregadoHandler(IEmpregadoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(AlterarEmpregadoCommand command)
        {            
            var empregado = _repository.RecuperarPorId(command.Id);

            if (empregado == null)
                return null;

            empregado.AlterarDados(command.Nome, command.Cargo, command.Departamento);

            _repository.Alterar(empregado);

            return new CommandResult(true, "Empregado alterado com sucesso", empregado);
        }
    }
}
