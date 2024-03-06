using Empregados.Domain.Entities;
using Empregados.Domain.Infra.Contexts;
using Empregados.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Infra.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly DataContext _context;

        public EmpresaRepository(DataContext context)
        {
            _context = context;
        }
        public void Alterar(Empresa empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Empresa Recuperar()
        {
            return _context.Empresas.AsNoTracking().FirstOrDefault();
        }
    }
}
