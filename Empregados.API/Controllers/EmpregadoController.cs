using Empregados.Domain.Commands;
using Empregados.Domain.Commands.Results;
using Empregados.Domain.Entities;
using Empregados.Domain.Handlers.Interfaces;
using Empregados.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Empregados.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpregadoController : ControllerBase
    {        

        [HttpGet]
        public ActionResult<IEnumerable<Empregado>> RecuperarEmpregados([FromServices] IRecuperaEmpregadosQueryHandler handler)
        {
            return Ok(handler.Handle());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Empregado> RecuperarEmpregadoPorId([FromServices] IRecuperaEmpregadoPorIdQueryHandler handler, Guid id)
        {
            var resultado = handler.Handle(id);
            
            if (resultado == null)
                return NotFound();

            return Ok(handler.Handle(id));
        }

        [HttpPost]
        public ActionResult<CommandResult> CriarEmpregado([FromServices] ICriarEmpregadoHandler handler, 
            [FromBody] CriarEmpregadoCommand command)
        {
            var resultado = handler.Handle(command);
            var empregado = (Empregado)resultado.Dados;
            return CreatedAtAction(nameof(RecuperarEmpregadoPorId), new { id = empregado.Id }, empregado);
        }

        [HttpPut]
        public ActionResult<CommandResult> AlterarEmpregado([FromServices] IAlterarEmpregadoHandler handler,
            [FromBody] AlterarEmpregadoCommand command)
        {
            var resultado = handler.Handle(command);
            
            if (resultado == null)
                return NotFound();

            var empregado = (Empregado)resultado.Dados;
            return CreatedAtAction(nameof(RecuperarEmpregadoPorId), new { id = empregado.Id }, empregado);
        }
        
        [HttpDelete]
        public ActionResult<CommandResult> ExcluirEmpregado([FromServices] IExcluirEmpregadoHandler handler,
            [FromBody] ExcluirEmpregadoCommand command)
        {
            var resultado = handler.Handle(command);

            if (resultado == null)
                return NotFound();
            

            return Ok(resultado);
        }
    }

}
