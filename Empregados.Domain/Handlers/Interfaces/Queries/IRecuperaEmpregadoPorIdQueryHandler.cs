using Empregados.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Handlers.Interfaces.Queries
{
    public interface IRecuperaEmpregadoPorIdQueryHandler
    {
        Empregado Handle(Guid id);
    }
}
