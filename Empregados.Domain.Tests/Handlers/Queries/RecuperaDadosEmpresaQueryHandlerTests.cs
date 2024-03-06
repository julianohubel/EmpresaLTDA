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
    public class RecuperaDadosEmpresaQueryHandlerTests
    {
        private Mock<IEmpresaRepository> _mock;
        private RecuperarDadosEmpresaQueryHandler _handler;        
        private Empresa EMPRESA_EXISTENTE = new Empresa("A", "B", "C");

        [TestMethod]
        public void Retorna_os_Dados_da_Empresa()
        {
            _mock = new();
            _mock.Setup(e => e.Recuperar()).Returns(() => EMPRESA_EXISTENTE);
            _handler = new RecuperarDadosEmpresaQueryHandler(_mock.Object);

            var result = _handler.Handle();

            Assert.AreEqual(result.Nome, EMPRESA_EXISTENTE.Nome);
            Assert.AreEqual(result.Endereco, EMPRESA_EXISTENTE.Endereco);
            Assert.AreEqual(result.Telefone, EMPRESA_EXISTENTE.Telefone);

        }
    }
}
