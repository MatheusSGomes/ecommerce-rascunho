using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

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

/* TemporalAll */
// var usuarioTemp = db.Usuarios!
//     .TemporalAll()
//     .Where(a => a.Id == 2)
//     .OrderBy(a => EF.Property<DateTime>(a, "PeriodoInicial"))
//     .ToList();
//
// foreach (var usuario in usuarioTemp)
// {
//     Console.WriteLine($"({usuario.Id}) {usuario.Nome} - Mãe: {usuario.NomeMae} - Situação: {usuario.SituacaoCadastro}");
// }

/* TemporalAsOf */

// var AsOf = new DateTime(2024, 8, 13, 11, 34, 00);
//
// var usuarioTemp = db.Usuarios!
//     .TemporalAsOf(AsOf)
//     .Where(a => a.Id == 2)
//     // .OrderBy(a => EF.Property<DateTime>(a, "PeriodoInicial"))
//     .ToList();
//
// foreach (var usuario in usuarioTemp)
// {
//     Console.WriteLine($"({usuario.Id}) {usuario.Nome} - Mãe: {usuario.NomeMae} - Situação: {usuario.SituacaoCadastro}");
// }
