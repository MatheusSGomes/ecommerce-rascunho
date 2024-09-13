using eCommerce.API.Database;
using eCommerce.Models;

var db = new eCommerceContext();

/* Global Filters */
// var usuarios = db.Usuarios!
//     .IgnoreQueryFilters() // ignora global filters
//     .ToList();
//
// foreach (var usuario in usuarios)
// {
//     Console.WriteLine($"({usuario.Id}) {usuario.Nome} - {usuario.SituacaoCadastro}");
// }

/* Temporal Tables */

// var novoUsuario = new Usuario()
// {
//     Nome = "Felipe Rodrigues",
//     Email = "felipe@email.com",
//     Sexo = "M",
//     NomeMae = "Joana",
//     RG = "321",
//     CPF = "456",
//     SituacaoCadastro = SituacaoCadastro.Ativo,
//     DataCadastro = DateTimeOffset.Now
// };
// db.Add(novoUsuario);

// var usuarioBanco = db.Usuarios!.Find(2);
// usuarioBanco.NomeMae = "Joana Oliveira";
// usuarioBanco.CPF = "963";
// db.SaveChanges();

// var usuarios = db.Usuarios!.ToList();
//
// foreach (var usuario in usuarios)
// {
//     Console.WriteLine($"({usuario.Id}) {usuario.Nome} - {usuario.NomeMae} - {usuario.SituacaoCadastro}");
// }
