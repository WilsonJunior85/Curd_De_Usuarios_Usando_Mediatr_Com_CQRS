using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Create;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Delete;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Update;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Queries.GetAllUsers;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Queries.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            var id = await _mediator.Send(command);
            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id));

            if (result is null) return NotFound("Registro não localizado!");
            

         
            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result) return NotFound("Registro não localizado");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteUserCommand(id));

            if (!result) return NotFound("Registro não localizado");

            return NoContent();
        }
    }
}
