using Empregados.Domain.Entities;

namespace Empregados.Domain.Infra.Contexts
{
    public class EmpresaContext
    {
        public EmpresaContext()
        {
            Empresa = new Empresa("Nome da Empresa", "Endereco Da empresa", "(99) 99999-9999");
        }
        public Empresa Empresa { get; set; }
    }
}
