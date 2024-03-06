using Empregados.Domain.Commands;
using Empregados.Domain.Handlers;
using Empregados.Domain.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Tests.Handlers
{
    [TestClass]
    public class CriaEmpregadoHandlerTest
    {

        private CriarEmpregadoCommand CRIAR_EMPREGADO_COMMAND = new CriarEmpregadoCommand("A", "B", "C");
        private Mock<IEmpregadoRepository> _mock;
        private CriarEmpregadoHandler _handler;

        [TestMethod]
        public void Dado_um_Empregado_valido_Retorna_Sucesso()
        {
            _mock = new();
            _handler = new CriarEmpregadoHandler(_mock.Object);
            var resultado = _handler.Handle(CRIAR_EMPREGADO_COMMAND);
            Assert.IsTrue(resultado.Sucesso);
        }
    }
}
