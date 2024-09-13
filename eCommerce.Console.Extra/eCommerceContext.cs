using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database;

public class eCommerceContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=localhost,1433;Database=ecommerce;User ID=sa;Password=1q2w3e4r@#$;Encrypt=False;")
            .LogTo(System.Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
            .EnableSensitiveDataLogging();
    }

    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Contato>? Contatos { get; set; }
    public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }
    public DbSet<Departamento>? Departamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .HasQueryFilter(a => a.SituacaoCadastro == "A");
    }
}
