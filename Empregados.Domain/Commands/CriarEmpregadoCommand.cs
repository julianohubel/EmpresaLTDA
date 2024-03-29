﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Commands
{
    public class CriarEmpregadoCommand
    {
        public CriarEmpregadoCommand(string nome, string cargo, string departamento)
        {
            Nome = nome;
            Cargo = cargo;
            Departamento = departamento;
        }

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
    }
}
