using Empregados.Domain.Entities;
using Empregados.Domain.Infra.Contexts;
using Empregados.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Infra.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly EmpresaContext _context;

        public EmpresaRepository(EmpresaContext context)
        {
            _context = context;
        }
        public void Alterar(Empresa empresa)
        {
            _context.Empresa = empresa;
        }

        public Empresa Recuperar()
        {
            return _context.Empresa;
        }
    }
}
