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
    public class EmpregadoRepository : IEmpregadoRepository
    {
        private readonly EmpregadosContext _context;

        public EmpregadoRepository(EmpregadosContext context)
        {
            _context = context;
        }
        public void Alterar(Empregado empregado)
        {
             var index = _context.Empregados.FindIndex(e => e.Id == empregado.Id);
            _context.Empregados[index].Nome = empregado.Nome;
            _context.Empregados[index].Cargo = empregado.Cargo;
            _context.Empregados[index].Departamento = empregado.Departamento;
        }

        public void Criar(Empregado empregado)
        {
            _context.Empregados.Add(empregado);
        }

        public Empregado RecuperarPorId(Guid id)
        {
            return _context.Empregados.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Empregado> RecuperarTodos()
        {
            return _context.Empregados;
        }
    }
}
