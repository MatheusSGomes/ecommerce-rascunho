using eCommerceConsole.Database;

var db = new EcommerceContext();
db.Usuarios.ToList();

foreach (var usuario in db.Usuarios)
    Console.WriteLine(usuario.Nome);
