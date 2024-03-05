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
    public class RecuperaEmpregadoPorIdQueryHandler : IRecuperaEmpregadoPorIdQueryHandler
    {
        private readonly IEmpregadoRepository _repository;

        public RecuperaEmpregadoPorIdQueryHandler(IEmpregadoRepository repository)
        {
            _repository = repository;
        }
        public Empregado Handle(Guid Id)
        {
            return _repository.RecuperarPorId(Id);
        }
    }
}
