using MediatR;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Delete
{
    public record DeleteUserCommand(int id) : IRequest<bool>;

}
