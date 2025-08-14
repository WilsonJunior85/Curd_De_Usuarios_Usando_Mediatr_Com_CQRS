namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Sobrenome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;
    }
}
