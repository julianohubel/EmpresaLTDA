using Empregados.Domain.Commands;
using Empregados.Domain.Entities;
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
    public class ExcluiEmpregadoHandlerTest
    {
        Mock<IEmpregadoRepository> mock;

        private ExcluirEmpregadoCommand EMPREGADO_COMMAND_EXISTENTE = new ExcluirEmpregadoCommand(new Guid("271dec83-cbeb-487b-959b-07ac302fcf29"));
        private ExcluirEmpregadoCommand EMPREGADO_COMMAND_INEXISTENTE = new ExcluirEmpregadoCommand(new Guid("271dec83-cbeb-487b-959b-07ac302fcf30"));
        private Empregado EMPREGADO_EXISTENTE = new Empregado("A", "B", "C");
        ExcluirEmpregadoHandler _handler;
        public ExcluiEmpregadoHandlerTest()
        {
            mock = new();
            mock.Setup(e => e.RecuperarPorId(EMPREGADO_COMMAND_EXISTENTE.Id)).Returns(() => EMPREGADO_EXISTENTE);
            mock.Setup(e => e.RecuperarPorId(EMPREGADO_COMMAND_INEXISTENTE.Id)).Returns(() => null);
            _handler = new ExcluirEmpregadoHandler(mock.Object);
        }

        [TestMethod]
        public void Dado_um_Empregado_Inexistente_Retorna_Null()
        {
            var result = _handler.Handle(EMPREGADO_COMMAND_INEXISTENTE);
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Dado_um_Empregado_Existente_Retorna_Sucesso()
        {
            var result = _handler.Handle(EMPREGADO_COMMAND_EXISTENTE);
            Assert.IsTrue(result.Sucesso);
        }
    }
}
