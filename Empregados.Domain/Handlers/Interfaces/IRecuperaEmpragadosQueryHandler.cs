

using Empregados.Domain.Entities;

namespace Empregados.Domain.Handlers.Interfaces
{
    public interface IRecuperaEmpregadosQueryHandler
    {
        IEnumerable<Empregado> Handle();
    }
}
