using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database;

public class eCommerceContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }

    public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>()
            .HasData(
                new Departamento { Id = 1, Nome = "Moda" },
                new Departamento { Id = 2, Nome = "Informática"},
                new Departamento { Id = 3, Nome = "Eletrodomésticos"},
                new Departamento { Id = 4, Nome = "Eletroportáteis"},
                new Departamento { Id = 5, Nome = "Mercado"},
                new Departamento { Id = 6, Nome = "Beleza"},
                new Departamento { Id = 7, Nome = "Móveis"});
    }

    #region Conexão com distinção de ambientes de execução 
    // Pesquisar strings de conexão: https://www.connectionstrings.com/sql-server/
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server=myServerName,myPortNumber;Database=myDataBase;User Id=myUsername;Password=myPassword;");
    // }
    #endregion
}
