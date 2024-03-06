using Empregados.Domain.Commands;
using Empregados.Domain.Commands.Results;
using Empregados.Domain.Entities;
using Empregados.Domain.Handlers.Interfaces;
using Empregados.Domain.Handlers.Interfaces.Queries;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Empregados.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        [HttpGet]        
        public ActionResult<Empresa> RecuperarEmpresa([FromServices] IRecuperarDadosEmpresaQueryHandler query)
        {
            return Ok(query.Handle());
        }

        [HttpPut]
        public ActionResult<CommandResult> AlteraEmpresa([FromServices] IAlterarEmpresaHandler handler,
            [FromBody] AlterarEmpresaCommand command)
        {


            var resultado = handler.Handle(command);

            if (resultado == null)
                return NotFound();
            
            return CreatedAtAction(nameof(RecuperarEmpresa), resultado);
        }

    }
}
