using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Data;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Queries.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserModel>
    {
        private readonly AppDbContext _context;

        public GetUserByIdHandler(AppDbContext context)
        {
            _context = context;
        }


        public async Task<UserModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            UserModel user = await _context.Usuarios.FindAsync(request.id);
            return user;
        }
    }
}
