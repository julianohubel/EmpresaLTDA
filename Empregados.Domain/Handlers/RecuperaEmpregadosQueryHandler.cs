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
    public class RecuperaEmpregadosQueryHandler : IRecuperaEmpregadosQueryHandler
    {
        private readonly IEmpregadoRepository _repository;

        public RecuperaEmpregadosQueryHandler(IEmpregadoRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Empregado> Handle()
        {
            return _repository.RecuperarTodos();
        }
    }
}