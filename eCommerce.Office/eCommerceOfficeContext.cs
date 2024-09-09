using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Office;

public class eCommerceOfficeContext : DbContext
{
    public DbSet<Colaborador>? Colaboradores { get; set; }
    public DbSet<ColaboradorSetor> ColaboradoresSetores { get; set; }
    public DbSet<Setor>? Setores { get; set; }

    public DbSet<Turma>? Turmas { get; set; }
    public DbSet<Veiculo>? Veiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=eCommerceOffice;User ID=sa;Password=1q2w3e4r@#$;Encrypt=False;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Mapping: ColaboradorSetor - Many-To-Many com 2 relacionamentos One-To-Many

        modelBuilder.Entity<ColaboradorSetor>()
            .HasKey(colaboradorSetor => new { colaboradorSetor.ColaboradorId, colaboradorSetor.SetorId });

        modelBuilder.Entity<ColaboradorSetor>()
            .HasOne(colaboradorSetor => colaboradorSetor.Colaborador)
            .WithMany(colaborador => colaborador.ColaboradorSetores)
            .HasForeignKey(colaboradorSetor => colaboradorSetor.ColaboradorId);

        modelBuilder.Entity<ColaboradorSetor>()
            .HasOne(colaboradorSetor => colaboradorSetor.Setor)
            .WithMany(setor => setor.ColaboradorSetores)
            .HasForeignKey(colaboradorSetor => colaboradorSetor.SetorId);

        // modelBuilder.Entity<Colaborador>()
        //     .HasMany(colaborador => colaborador.ColaboradorSetores)
        //     .WithOne(colaboradorSetor => colaboradorSetor.Colaborador)
        //     .HasForeignKey(colaboradorSetor => colaboradorSetor.ColaboradorId);
        //
        // modelBuilder.Entity<Setor>()
        //     .HasMany(setor => setor.ColaboradorSetores)
        //     .WithOne(colaboradorSetor => colaboradorSetor.Setor)
        //     .HasForeignKey(colaboradorSetor => colaboradorSetor.SetorId);

        #endregion

        #region Seeds

        modelBuilder.Entity<Colaborador>()
            .HasData(
                new Colaborador { Id = 1, Nome = "José" },
                new Colaborador { Id = 2, Nome = "Maria" },
                new Colaborador { Id = 3, Nome = "Felipe" },
                new Colaborador { Id = 4, Nome = "Tiago" },
                new Colaborador { Id = 5, Nome = "Mariana" },
                new Colaborador { Id = 6, Nome = "Jéssica" });

        modelBuilder.Entity<Setor>()
            .HasData(
                new Setor { Id = 1, Nome = "Logística"},
                new Setor { Id = 2, Nome = "Financeiro"},
                new Setor { Id = 3, Nome = "Administrativo"});

        modelBuilder.Entity<ColaboradorSetor>()
            .HasData(
                new ColaboradorSetor { SetorId = 1, ColaboradorId = 1, DataRegistroCriado = DateTimeOffset.Now },
                new ColaboradorSetor { SetorId = 1, ColaboradorId = 2, DataRegistroCriado = DateTimeOffset.Now },
                new ColaboradorSetor { SetorId = 2, ColaboradorId = 3, DataRegistroCriado = DateTimeOffset.Now },
                new ColaboradorSetor { SetorId = 2, ColaboradorId = 4, DataRegistroCriado = DateTimeOffset.Now },
                new ColaboradorSetor { SetorId = 3, ColaboradorId = 5, DataRegistroCriado = DateTimeOffset.Now },
                new ColaboradorSetor { SetorId = 3, ColaboradorId = 6, DataRegistroCriado = DateTimeOffset.Now });

        #endregion

        #region Mapping: Colaborador <=> Turma

        modelBuilder.Entity<Colaborador>()
            .HasMany(colaborador => colaborador.Turmas)
            .WithMany(turma => turma.Colaboradores);

        modelBuilder.Entity<Turma>().HasData(
            new Turma { Id = 1, Nome = "Turma A1"},
            new Turma { Id = 2, Nome = "Turma A2"},
            new Turma { Id = 3, Nome = "Turma A3"},
            new Turma { Id = 4, Nome = "Turma A4"},
            new Turma { Id = 5, Nome = "Turma A5"});
        
        #endregion
    }
}
