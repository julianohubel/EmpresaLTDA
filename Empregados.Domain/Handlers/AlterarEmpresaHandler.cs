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
    public class AlterarEmpresaHandler : IAlterarEmpresaHandler
    {
        private readonly IEmpresaRepository _empresaRepository;

        public AlterarEmpresaHandler(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public ICommandResult Handle(Empresa empresa)
        {
             _empresaRepository.Alterar(empresa);

            return new CommandResult(true, "Empresa alterada com sucesso", empresa);
        }
    }
}
