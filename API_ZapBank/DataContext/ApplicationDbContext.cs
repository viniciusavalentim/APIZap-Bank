using API_ZapBank.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ZapBank.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        //nessa aplicação vai ser onde vou colocar as tabelas dos MODELS
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //sempre vai ser esse contexto para conectar ao banco de dados
            :base(options)
        { 
        }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<ClientModel> Client { get; set; }


    }
}
