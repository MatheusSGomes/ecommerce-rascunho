using eCommerce.Office;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceOfficeContext();

#region Many-To-Many > 2x One-To-Many
// setor > colaboradorSetor > colaborador

var resultado = db.Setores!
    .Include(setor => setor.ColaboradorSetores)
    .ThenInclude(colaboradorSetor => colaboradorSetor.Colaborador);

foreach (var setor in resultado)
{
    Console.WriteLine(setor.Nome);

    foreach (var colaboradorSetor in setor.ColaboradorSetores)
    {
        Console.WriteLine(" - " + colaboradorSetor.Colaborador.Nome);
    }
}
#endregion
