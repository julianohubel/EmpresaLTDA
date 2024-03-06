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
    public class RecuperarDadosEmpresaQuery : IRecuperarDadosEmpresaQuery
    {
        private readonly IEmpresaRepository _repository;

        public RecuperarDadosEmpresaQuery(IEmpresaRepository repository)
        {
            _repository = repository;
        }
        public Empresa Handle()
        {
            return _repository.Recuperar();
        }
    }
}
