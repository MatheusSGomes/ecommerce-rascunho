using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Models.FluentAPI.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("tb_usuarios");
        builder.Property(usuario => usuario.RG)
            .HasColumnName("registro_geral")
            .HasMaxLength(12);
    }
}
    
