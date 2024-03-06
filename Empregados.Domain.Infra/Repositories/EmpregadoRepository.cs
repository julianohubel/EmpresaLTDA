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
    public class EmpregadoRepository : IEmpregadoRepository
    {
        private readonly DataContext _context;

        public EmpregadoRepository(DataContext context)
        {
            _context = context;
        }
        public void Alterar(Empregado empregado)
        {
            _context.Entry(empregado).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Criar(Empregado empregado)
        {
            _context.Empregados.Add(empregado);
            _context.SaveChanges();
        }
       

        public Empregado RecuperarPorId(Guid id)
        {
            return _context.Empregados.AsNoTracking().FirstOrDefault(e => e.Id == id && !e.Excluido);
        }

        public IEnumerable<Empregado> RecuperarTodos()
        {
            return _context.Empregados.AsNoTracking().Where(e => !e.Excluido).OrderBy(e => e.Nome);
        }
    }
}
