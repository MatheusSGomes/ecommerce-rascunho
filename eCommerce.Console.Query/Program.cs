using eCommerce.API.Database;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();

// var usuarios = db.Usuarios!.ToList();

// foreach (var usuario in usuarios)
// {
//     Console.WriteLine($"- {usuario.Nome}");
// }

// var usuario01 = db.Usuarios!.Find(2);
// Console.WriteLine($"- {usuario01.Nome}");


// var usuario2 = db.Usuarios!.Where(a => a.Email == "jose@gmail.com").First();
// Console.WriteLine($"- {usuario2.Nome}");

// var usuario3 = db.Usuarios!.OrderBy(a => a.Nome).LastOrDefault();

// var usuario01 = db.Usuarios!.FirstOrDefault(a => a.Email == "jose@gmail.com");
// var usuario01 = db.Usuarios!.SingleOrDefault(a => a.Nome.Contains("a"));
// Console.WriteLine($"Código: {usuario01.Id} - Nome: {usuario01.Nome}");

// var countUsuariosLetraA = db.Usuarios!.Where(a => a.Nome.Contains("a")).Count();
// Console.WriteLine($"Registros com letra 'a': {countUsuariosLetraA}");


// var max = db.Usuarios!.Max(a => a.Id);
// Console.WriteLine($"Id máximo {max}");

// var min = db.Usuarios!.Min(a => a.Id);
// Console.WriteLine($"Id mínimo {min}");


/* Include */
// var usuarios = db.Usuarios!
//     .Include(a => a.Contato)
//     .Include(a => a.EnderecosEntrega.Where(e => e.Estado == "SP"))
//     .ToList();
//
// foreach (var usuario in usuarios)
// {
//     Console.WriteLine($"- {usuario.Nome} - {usuario.Contato!.Celular} - QTD. de endereços: {usuario.EnderecosEntrega!.Count}");
//
//     foreach (var endereco in usuario.EnderecosEntrega)
//     {
//         Console.WriteLine($"-- {endereco.NomeEndereco} - {endereco.CEP} - {endereco.Cidade}");
//     }
// }

/* ThenInclude */
// var contatos = db.Contatos!
//     .Include(contato => contato.Usuario)
//     .ThenInclude(usuario => usuario!.EnderecosEntrega)
//     .Include(enderecoEntrega => enderecoEntrega.Usuario)
//     .ThenInclude(usuario => usuario!.Departamentos)
//     .ToList();
//
// foreach (var contato in contatos)
// {
//     Console.WriteLine(@$"- {contato.Telefone} -> {contato.Usuario!.Nome} 
//                          - Qtd. Enderecos: {contato.Usuario.EnderecosEntrega!.Count}
//                          - Qtd. Departamentos: {contato.Usuario.Departamentos}");
// }

/* Autoinclude e IgnoreAutoIncludes */
// var usuarios = db.Usuarios!.IgnoreAutoIncludes().ToList();
//
// foreach (var usuario in usuarios)
// {
//     Console.WriteLine($"Nome: {usuario.Nome} - Telefone: {usuario.Contato?.Telefone}");
// }

/* Explicit Load */
// var usuario = db.Usuarios!.IgnoreAutoIncludes().FirstOrDefault(usuario => usuario.Id == 2);
//
// Console.WriteLine($"Usuário: {usuario.Nome} - Contato: {usuario.Contato?.Telefone} - Endereços: {usuario.EnderecosEntrega?.Count}");
// // Usuário: Maurício Ribeiro - Contato:  - Endereços: 
//
// db.Entry(usuario).Reference(a => a.Contato).Load();
//
// Console.WriteLine($"Usuário: {usuario.Nome} - Contato: {usuario.Contato?.Telefone} - Endereços: {usuario.EnderecosEntrega?.Count}");
// // Usuário: Maurício Ribeiro - Contato: (11) 986520-8484 - Endereços:
//
// db.Entry(usuario).Collection(a => a.EnderecosEntrega!).Load();
//
// Console.WriteLine($"Usuário: {usuario.Nome} - Contato: {usuario.Contato?.Telefone} - Endereços: {usuario.EnderecosEntrega?.Count}");
// // Usuário: Maurício Ribeiro - Contato: (11) 986520-8484 - Endereços: 2
//
// var enderecos = db.Entry(usuario)
//     .Collection(a => a.EnderecosEntrega!)
//     .Query()
//     .Where(a => a.Estado == "SP")
//     .ToList();
//
// foreach (var endereco in enderecos)
// {
//     Console.WriteLine($"{endereco.NomeEndereco}");
// }

/* Lazy Loading com proxies */
// var usuario = db.Usuarios!.Find(2);
//
// Console.WriteLine($"Nome: {usuario.Nome} - Endereço: {usuario.EnderecosEntrega?.Count}");


/* Split Query - Consulta Dividida */
// var usuario = db.Usuarios!
//     .AsSplitQuery()
//     .Include(u => u.EnderecosEntrega).FirstOrDefault(u => u.Id == 2);
//
// Console.WriteLine($"- Nome: {usuario!.Nome} - Endereços: {usuario.EnderecosEntrega?.Count}");

/* Skip e Take */
// var usuarios = db.Usuarios!
//     .Skip(1)
//     .Take(2)
//     .ToList();
//
// foreach (var usuario in usuarios)
// {
//     Console.WriteLine($"-- {usuario.Nome}");
// }
