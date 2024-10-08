namespace eCommerce.Office.Models;

public class ColaboradorSetor
{
    public int ColaboradorId { get; set; }
    public int SetorId { get; set; }
    public DateTimeOffset DataRegistroCriado { get; set; }

    public Colaborador Colaborador { get; set; } = null!;
    public Setor Setor { get; set; } = null!;
}
