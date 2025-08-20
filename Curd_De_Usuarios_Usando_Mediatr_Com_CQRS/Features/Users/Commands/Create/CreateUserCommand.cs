using MediatR;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Create
{
  public record CreateUserCommand(string Nome, string Sobrenome, string Email, string Cpf): IRequest<int>;
   
}
