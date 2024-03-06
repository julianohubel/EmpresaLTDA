using Empregados.Domain.Entities;

namespace Empregados.Domain.Handlers.Interfaces.Queries
{
    public interface IRecuperaEmpregadosQueryHandler
    {
        IEnumerable<Empregado> Handle();
    }
}
