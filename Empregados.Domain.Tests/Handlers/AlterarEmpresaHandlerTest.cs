using Empregados.Domain.Commands;
using Empregados.Domain.Entities;
using Empregados.Domain.Handlers;
using Empregados.Domain.Repositories;
using Moq;

namespace Empregados.Domain.Tests.Handlers
{
    [TestClass]
    public class AlterarEmpresaHandlerTest
    {
        private Mock<IEmpresaRepository> _mock;
        private AlterarEmpresaHandler _handler;
        private AlterarEmpresaCommand EMPRESA_COMMAND_EXISTENTE = new AlterarEmpresaCommand(new Guid("271dec83-cbeb-487b-959b-07ac302fcf29"), "A", "B", "C");
        private AlterarEmpresaCommand EMPRESA_COMMAND_INEXISTENTE = new AlterarEmpresaCommand(new Guid("271dec83-cbeb-487b-959b-07ac302fcf30"), "X", "Y", "Z");
        private Empresa EMPRESA_EXISTENTE  = new Empresa("A", "B", "C");    
       

        [TestMethod]
        public void Dado_uma_Empresa_Inexistente_Retorna_Null()
        {
            _mock = new();
            _mock.Setup(e => e.Recuperar()).Returns(() => null);
            _handler = new AlterarEmpresaHandler(_mock.Object);
            var resultado = _handler.Handle(EMPRESA_COMMAND_INEXISTENTE);
            Assert.IsNull(resultado);
 
        }
        [TestMethod]
        public void Dado_uma_Empresa_Existente_Retorna_Sucesso()
        {
            _mock = new();
            _mock.Setup(e => e.Recuperar()).Returns(() => EMPRESA_EXISTENTE);
            _handler = new AlterarEmpresaHandler(_mock.Object);
            var resultado = _handler.Handle(EMPRESA_COMMAND_EXISTENTE);
            Assert.IsTrue(resultado.Sucesso);
        }
    }
}
