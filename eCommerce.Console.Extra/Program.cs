using eCommerce.API.Database;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();

/* Global Filters */
var usuarios = db.Usuarios!
    .IgnoreQueryFilters() // ignora global filters
    .ToList();

foreach (var usuario in usuarios)
{
    Console.WriteLine($"({usuario.Id}) {usuario.Nome} - {usuario.SituacaoCadastro}");
}
