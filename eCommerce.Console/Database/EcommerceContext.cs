using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using eCommerceConsole.Models;

namespace eCommerceConsole.Database;

public partial class EcommerceContext : DbContext
{
    public EcommerceContext()
    {
    }

    public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contato> Contatos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<EnderecosEntrega> EnderecosEntregas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ecommerce;User ID=sa;Password=1q2w3e4r@#$;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contato>(entity =>
        {
            entity.HasIndex(e => e.UsuarioId, "IX_Contatos_UsuarioId").IsUnique();

            entity.HasOne(d => d.Usuario).WithOne(p => p.Contato).HasForeignKey<Contato>(d => d.UsuarioId);
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasMany(d => d.Usuarios).WithMany(p => p.Departamentos)
                .UsingEntity<Dictionary<string, object>>(
                    "DepartamentoUsuario",
                    r => r.HasOne<Usuario>().WithMany().HasForeignKey("UsuariosId"),
                    l => l.HasOne<Departamento>().WithMany().HasForeignKey("DepartamentosId"),
                    j =>
                    {
                        j.HasKey("DepartamentosId", "UsuariosId");
                        j.ToTable("DepartamentoUsuario");
                        j.HasIndex(new[] { "UsuariosId" }, "IX_DepartamentoUsuario_UsuariosId");
                    });
        });

        modelBuilder.Entity<EnderecosEntrega>(entity =>
        {
            entity.ToTable("EnderecosEntrega");

            entity.HasIndex(e => e.UsuarioId, "IX_EnderecosEntrega_UsuarioId");

            entity.Property(e => e.Cep).HasColumnName("CEP");

            entity.HasOne(d => d.Usuario).WithMany(p => p.EnderecosEntregas).HasForeignKey(d => d.UsuarioId);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.Cpf).HasColumnName("CPF");
            entity.Property(e => e.Rg).HasColumnName("RG");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
