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

    #region Conexão com distinção de ambientes de execução 
    // Pesquisar strings de conexão: https://www.connectionstrings.com/sql-server/
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server=myServerName,myPortNumber;Database=myDataBase;User Id=myUsername;Password=myPassword;");
    // }
    #endregion
}
