using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models.FluentAPI;

public class eCommerceFluentContext: DbContext
{
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Contato>? Contatos { get; set; }
    public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }
    public DbSet<Departamento>? Departamentos { get; set; }

    public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");
        modelBuilder.Entity<Usuario>()
            .Property(property => property.RG)
            .HasColumnName("REGISTRO_GERAL")
            .HasMaxLength(10)
            .HasDefaultValue("RG_AUSENTE")
            .IsRequired();

        modelBuilder.Entity<Usuario>().Ignore(prop => prop.Sexo); // Equivalente ao notMapped

        modelBuilder.Entity<Usuario>().Property(prop => prop.Id).ValueGeneratedOnAdd(); // Equivalente ao DatabaseGenerated(identity)
        // modelBuilder.Entity<Usuario>().Property(prop => prop.Id).ValueGeneratedNever(); // Equivalente ao DatabaseGenerated(none)
        // modelBuilder.Entity<Usuario>().Property(prop => prop.Id).ValueGeneratedOnUpdate(); // Equivalente ao DatabaseGenerated(computed)


        modelBuilder.Entity<Usuario>().HasIndex("CPF").HasFilter("[CPF] IS NOT NULL").HasDatabaseName("IX_CPF_UNIQUE");
        modelBuilder.Entity<Usuario>().HasIndex(prop => prop.CPF).IsUnique();
        
        // índice composto
        modelBuilder.Entity<Usuario>().HasIndex("CPF", "Email");
        modelBuilder.Entity<Usuario>().HasIndex(prop => new { prop.CPF, prop.Email });

        modelBuilder.Entity<Usuario>().HasKey("Id");
        modelBuilder.Entity<Usuario>().HasKey(prop => prop.Id);
        
        // Chave composta
        modelBuilder.Entity<Usuario>().HasKey("Id", "CPF");
        modelBuilder.Entity<Usuario>().HasKey(prop => new { prop.Id, prop.CPF });
        
        // Alternativas
        modelBuilder.Entity<Usuario>().HasNoKey();
        modelBuilder.Entity<Usuario>().HasAlternateKey("CPF", "Email");
        
        // Relacionamentos
        // One - aponta para uma propriedade de navegação simples (composição)
        // Many - aponta para uma propriedade de navegação de coleção (lista, ienumerable...)
        modelBuilder.Entity<Usuario>()
            .HasOne(usuario => usuario.Contato)
            .WithOne(contato => contato.Usuario)
            .HasForeignKey<Contato>(contato => contato.UsuarioId);

        modelBuilder.Entity<Usuario>()
            .HasMany(usuario => usuario.EnderecosEntrega)
            .WithOne(endEntrega => endEntrega.Usuario)
            .HasForeignKey(endEntrega => endEntrega.UsuarioId);

        modelBuilder.Entity<Usuario>()
            .HasMany(usuario => usuario.Departamentos)
            .WithMany(departamentos => departamentos.Usuarios);
    }
}
