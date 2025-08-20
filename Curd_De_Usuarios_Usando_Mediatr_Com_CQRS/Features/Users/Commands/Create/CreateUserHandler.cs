using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Data;
using MediatR;
using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Features.Users.Commands.Create
{

    public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateUserHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            UserModel user = new UserModel
            {
                Nome = request.Nome,
                Sobrenome = request.Sobrenome,
                Email = request.Email,
                Cpf = request.Cpf,
            };

            _context.Usuarios.Add(user);
            await _context.SaveChangesAsync(cancellationToken);
            return user.Id;
        }
    }
}
