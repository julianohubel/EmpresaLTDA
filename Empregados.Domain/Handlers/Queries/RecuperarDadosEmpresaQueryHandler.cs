using Empregados.Domain.Entities;
using Empregados.Domain.Handlers.Interfaces.Queries;
using Empregados.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Handlers.Queries
{
    public class RecuperarDadosEmpresaQueryHandler : IRecuperarDadosEmpresaQueryHandler
    {
        private readonly IEmpresaRepository _repository;

        public RecuperarDadosEmpresaQueryHandler(IEmpresaRepository repository)
        {
            _repository = repository;
        }
        public Empresa Handle()
        {
            return _repository.Recuperar();
        }
    }
}
