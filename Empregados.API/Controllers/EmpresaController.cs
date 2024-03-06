using Empregados.Domain.Entities;
using Empregados.Domain.Handlers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Empregados.API.Controllers
{
    public class EmpresaController : ControllerBase
    {
        [HttpGet]        
        public ActionResult<Empresa> RecuperarEmpresa([FromServices] IRecuperarDadosEmpresaQuery query)
        {
            return Ok(query.Handle());
        }

        [HttpPut]
        public ActionResult<Empresa> AlteraEmpresa([FromServices] IAlterarEmpresaHandler handler,
            [FromBody] Empresa empresa)
        {
            return Ok(handler.Handle(empresa));
        }

    }
}
