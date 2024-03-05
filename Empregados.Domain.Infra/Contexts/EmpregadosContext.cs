using Empregados.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Infra.Contexts
{
    public class EmpregadosContext
    {
        public EmpregadosContext()
        {
            Empregados = new List<Empregado>();
        }
        public List<Empregado> Empregados { get; set; }
    }
}
