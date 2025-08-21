using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models;
using MediatR;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Queries.GetAllUsers
{

    public record GetAllUsersQuery(): IRequest<List<UserModel>>;
    
}
