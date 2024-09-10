namespace eCommerce.Office.Models;

/*
 * Colaborador (1 > *) ColaboradorVeiculo (* < 1) Veículo
 */
public class ColaboradorVeiculo
{
    /* MER */
    public int ColaboradorId { get; set; }
    public int VeiculoId { get; set; }

    public DateTimeOffset DataInicioDeVinculo { get; set; }
    
    /* POO */
    public Colaborador Colaborador { get; set; } = null!;
    public Veiculo Veiculo { get; set; } = null!;
}
