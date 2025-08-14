using Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace Curd_De_Usuarios_Usando_Mediatr_Com_CQRS.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<UserModel> Usuarios { get; set;}


    }
}
