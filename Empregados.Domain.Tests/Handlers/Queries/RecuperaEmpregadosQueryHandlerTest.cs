using Empregados.Domain.Entities;
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
    public class RecuperaEmpregadosQueryHandlerTest
    {

        Mock<IEmpregadoRepository> _mock;        
        private List<Empregado> EMPREGADOs_EXISTENTEs = new List<Empregado> {
                                            new Empregado("A", "B", "C"),
                                            new Empregado("D", "E", "F"),
                                            new Empregado("G", "H", "I")};

        RecuperaEmpregadosQueryHandler _handler;

        [TestMethod]
        public void Retorna_Lista_de_Empregados()
        {
            _mock = new();

            _mock.Setup(e => e.RecuperarTodos()).Returns(EMPREGADOs_EXISTENTEs);
            _handler = new RecuperaEmpregadosQueryHandler(_mock.Object);

            var result = _handler.Handle();

            Assert.AreEqual(result.Count(), EMPREGADOs_EXISTENTEs.Count);
            Assert.AreEqual(result.ToList()[1].Nome, EMPREGADOs_EXISTENTEs[1].Nome);
            Assert.AreEqual(result.ToList()[1].Cargo, EMPREGADOs_EXISTENTEs[1].Cargo);
            Assert.AreEqual(result.ToList()[2].Departamento, EMPREGADOs_EXISTENTEs[2].Departamento);

        }
    }
}
