using Empregados.Domain.Commands;
using Empregados.Domain.Commands.Interfaces;
using Empregados.Domain.Commands.Results;
using Empregados.Domain.Entities;
using Empregados.Domain.Handlers.Interfaces;
using Empregados.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Handlers
{
    public class CriarEmpregadoHandler : ICriarEmpregadoHandler
    {
        private readonly IEmpregadoRepository _repository;

        public CriarEmpregadoHandler(IEmpregadoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CriarEmpregadoCommand command)
        {
            var empregado = new Empregado(command.Nome, command.Cargo, command.Departamento);

            _repository.Criar(empregado);

            return new CommandResult(true, "Empregado adicionado com sucesso", empregado);
        }
    }
}
