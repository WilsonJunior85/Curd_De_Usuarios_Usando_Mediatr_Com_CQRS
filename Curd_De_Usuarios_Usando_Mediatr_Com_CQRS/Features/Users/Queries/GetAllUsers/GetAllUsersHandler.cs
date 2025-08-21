using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Data;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserModel>>
    {
        private readonly AppDbContext _context;

        public GetAllUsersHandler(AppDbContext context)
        {
           _context = context;
        }


        public async Task<List<UserModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
