using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models;

[Index(nameof(Email), IsUnique = true, Name = "IX_EMAIL_UNIQUE")]
[Index(nameof(Nome), nameof(Sexo), nameof(RG))]
[Table("tb_usuarios")]
public class Usuario
{
    // Convensão do Id - UsuarioId = PK - Do tipo "Identity"
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    
    [Required]
    [MaxLength(15)]
    public string? Sexo { get; set; }

    [Column("registro_geral")]
    public string? RG { get; set; }
    public string CPF { get; set; } = null!;
    public string? NomeMae { get; set; }
    public string? SituacaoCadastro { get; set; }
    
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Matricula { get; set; }
    
    /*
     * RegistroAtivo = (SituacaoCadastro == "Ativo") ? true : false
     * Propósito é facilitar a leitura no software - não precisa ser persistido
     */
    [NotMapped]
    public bool RegistroAtivo { get; set; }
    
    public DateTimeOffset DataCadastro { get; set; }
    
    [ForeignKey("UsuarioId")]
    public Contato? Contato { get; set; }
    public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }
    public ICollection<Departamento>? Departamentos { get; set; }
    
    /*
     * Navegações:
     * - Usuario.PedidosCompradosPeloCliente
     * - Usuario.PedidosGerenciadosPeloColaborador
     * - Usuario.PedidosSupervisionadosPeloColaboradorSupervisor
     *
     * PedidosCompradosPeloCliente
     * - ClienteId *
     * - ColaboradorId
     * - SupervisorId
     *
     * PedidosGerenciadosPeloColaborador:
     * - ClienteId
     * - ColaboradorId *
     * - SupervisorId
     *
     * PedidosSupervisionadosPeloColaboradorSupervisor:
     * - ClienteId
     * - ColaboradorId
     * - SupervisorId *
     */
    [InverseProperty("Cliente")]
    public ICollection<Pedido>? PedidosCompradosPeloCliente { get; set; }
    
    [InverseProperty("Colaborador")]
    public ICollection<Pedido>? PedidosGerenciadosPeloColaborador { get; set; }
    
    [InverseProperty("Supervisor")]
    public ICollection<Pedido>? PedidosSupervisionadosPeloColaboradorSupervisor { get; set; }
}
