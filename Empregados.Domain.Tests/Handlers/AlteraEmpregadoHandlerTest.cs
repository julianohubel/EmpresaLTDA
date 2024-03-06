using Empregados.Domain.Commands;
using Empregados.Domain.Handlers;
using Moq;
using Empregados.Domain.Repositories;
using Empregados.Domain.Entities;

namespace Empregados.Domain.Tests.Handlers
{

    [TestClass]
    public class AlteraEmpregadoHandlerTest
    {
        Mock<IEmpregadoRepository> mock;

        private AlterarEmpregadoCommand EMPREGADO_COMMAND_EXISTENTE = new AlterarEmpregadoCommand(new Guid("271dec83-cbeb-487b-959b-07ac302fcf29"), "A", "B", "C");
        private AlterarEmpregadoCommand EMPREGADO_COMMAND_INEXISTENTE = new AlterarEmpregadoCommand(new Guid("271dec83-cbeb-487b-959b-07ac302fcf30"), "X", "Y", "Z");
        private Empregado EMPREGADO_EXISTENTE = new Empregado("A", "B", "C");

        AlterarEmpregadoHandler _handler;

        public AlteraEmpregadoHandlerTest()
        {
            mock = new();
            mock.Setup(e => e.RecuperarPorId(EMPREGADO_COMMAND_EXISTENTE.Id)).Returns(() => EMPREGADO_EXISTENTE);
            mock.Setup(e => e.RecuperarPorId(EMPREGADO_COMMAND_INEXISTENTE.Id)).Returns(() => null);
            _handler = new AlterarEmpregadoHandler(mock.Object);
        }

        [TestMethod]
        public void Dado_um_Empregado_Inexistente_Retorna_Null()
        {            
            var result =  _handler.Handle(EMPREGADO_COMMAND_INEXISTENTE);
            
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
