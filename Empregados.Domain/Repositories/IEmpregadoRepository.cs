using Empregados.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Repositories
{
    public interface IEmpregadoRepository
    {
        void Criar(Empregado empregado);
        void Alterar(Empregado empregado);
        IEnumerable<Empregado> RecuperarTodos();
        Empregado RecuperarPorId(Guid id);
    }
}
