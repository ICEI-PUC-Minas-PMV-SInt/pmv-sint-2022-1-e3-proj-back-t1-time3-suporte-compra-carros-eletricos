using Microsoft.EntityFrameworkCore;

namespace eletric_app.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<VeiculoC> VeiculosC { get; set; }
        public DbSet<VeiculoE> VeiculosE { get; set; }
    }
}
