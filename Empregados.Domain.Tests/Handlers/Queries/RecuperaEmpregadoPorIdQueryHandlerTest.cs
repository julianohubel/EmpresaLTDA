using Empregados.Domain.Commands;
using Empregados.Domain.Entities;
using Empregados.Domain.Handlers;
using Empregados.Domain.Handlers.Queries;
using Empregados.Domain.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Domain.Tests.Handlers.Queries
{
    [TestClass]
    public class RecuperaEmpregadoPorIdQueryHandlerTest
    {

        Mock<IEmpregadoRepository> mock;

        private Guid EMPREGADO_EXISTENTE_ID = new Guid("271dec83-cbeb-487b-959b-07ac302fcf29");
        private Guid EMPREGADO_INEXISTENTE_ID = new Guid("271dec83-cbeb-487b-959b-07ac302fcf30");
        private Empregado EMPREGADO_EXISTENTE = new Empregado("A", "B", "C");

        RecuperaEmpregadoPorIdQueryHandler _handler;

        public RecuperaEmpregadoPorIdQueryHandlerTest()
        {
            mock = new();
            mock.Setup(e => e.RecuperarPorId(EMPREGADO_EXISTENTE_ID)).Returns(() => EMPREGADO_EXISTENTE);
            mock.Setup(e => e.RecuperarPorId(EMPREGADO_INEXISTENTE_ID)).Returns(() => null);
            _handler = new RecuperaEmpregadoPorIdQueryHandler(mock.Object);
        }


        [TestMethod]
        public void Dado_um_Id_Invalido_Retorna_Null()
        {
            var result = _handler.Handle(EMPREGADO_INEXISTENTE_ID);
            Assert.IsNull(result);
        }

        public void Dado_um_Id_Valido_Retorna_um_Empregado()
        {
            var result = _handler.Handle(EMPREGADO_EXISTENTE_ID);

            Assert.AreEqual(result.Nome, EMPREGADO_EXISTENTE.Nome);
            Assert.AreEqual(result.Cargo, EMPREGADO_EXISTENTE.Cargo);
            Assert.AreEqual(result.Departamento, EMPREGADO_EXISTENTE.Departamento);
        }
    }
}
