using Empregados.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Handlers.Interfaces
{
    public interface IRecuperarDadosEmpresaQuery
    {

        Empresa Handle();
    }
}
