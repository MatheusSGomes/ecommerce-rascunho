using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models;

public class Pedido
{
    /*
     * Navegações:
     * Pedido.Cliente.Nome
     * Pedido.Colaborador.Nome
     * Pedido.Supervisor.Nome
     */
    public int Id { get; set; }

    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }

    [ForeignKey("Colaborador")]
    public int ColaboradorId { get; set; }

    [ForeignKey("Supervisor")]
    public int SupervisorId { get; set; }

    public Usuario? Usuario { get; set; }
    public Usuario? Colaborador { get; set; }
    public Usuario? Supervisor { get; set; }
}
