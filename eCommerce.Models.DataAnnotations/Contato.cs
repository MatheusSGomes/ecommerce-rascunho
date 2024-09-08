using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models;

public class Contato
{
    public int Id { get; set; }
    public string? Telefone { get; set; }
    public string? Celular { get; set; }

    // Coluna MER - Convensão: {Modelo} {PK}
    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }

    // POO (usada para navegar entre objetos)
    [ForeignKey("UsuarioId")]
    public Usuario? Usuario { get; set; }
}
