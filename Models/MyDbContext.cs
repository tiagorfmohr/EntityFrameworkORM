using Microsoft.EntityFrameworkCore;

namespace Trento.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
