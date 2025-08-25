using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Data;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Update;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models;
using MediatR;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Delete
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {

        private readonly AppDbContext _context;

        public DeleteUserHandler(AppDbContext context)
        {
            _context = context;
        }



        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
           UserModel user = await _context.Usuarios.FindAsync(request.id);

            if(user == null) return false;

            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }
    }

}
