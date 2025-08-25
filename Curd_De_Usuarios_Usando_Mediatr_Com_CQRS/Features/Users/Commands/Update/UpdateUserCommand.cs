using MediatR;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Update
{
    public record UpdateUserCommand(int id, string nome, string sobrenome, string email, string cpf): IRequest<bool>;
    
}
