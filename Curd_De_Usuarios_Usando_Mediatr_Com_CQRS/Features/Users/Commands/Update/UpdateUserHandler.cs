using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Data;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models;
using MediatR;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Update
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly AppDbContext _context;

        public UpdateUserHandler(AppDbContext context)
        {
            _context = context;
        }


        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            UserModel user = await _context.Usuarios.FindAsync(request.id);

            if (user == null) return false;

            user.Nome = request.nome;
            user.Email = request.email;
            user.Sobrenome = request.sobrenome;
            user.Cpf = request.cpf;

            _context.Usuarios.Update(user);
            await _context.SaveChangesAsync();

            return true;

        }
    }
}
