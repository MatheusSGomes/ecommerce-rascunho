using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();

// Unit of Works - Add, update, remove

var usuario01 = new Usuario() { Nome = "Mathias", Email  = "mathias@email.com", CPF = "678" };
db.Usuarios.Add(usuario01);

var usuario02 = db.Usuarios.Find(2);
usuario02!.Nome = "Josefina";
db.Usuarios.Update(usuario02);

var usuario03 = db.Usuarios.Find(3);
db.Usuarios.Remove(usuario03!);

var usuario04 = new Usuario() { Id = 4, Nome = "Felipe Brandão", NomeMae = "Patrícia Brandão "};
db.Usuarios.Attach(usuario04);
db.Entry(usuario04).State = EntityState.Unchanged;

db.Entry(usuario04).Property(a => a.Nome).IsModified = true;
db.Entry(usuario04).Property(a => a.NomeMae).IsModified = false;

Console.WriteLine(db.ChangeTracker.DebugView.LongView);

// TRACKING
// var usuario1 = db.Usuarios.FirstOrDefault(usuario => usuario.Id == 2);
// usuario1.Nome = "Maurício";

// NO TRACKING
// var usuario2 = db.Usuarios.AsNoTracking().FirstOrDefault(usuario => usuario.Id == 2);
// usuario2.Nome = "José Antônio";
// db.Update(usuario2); // Obrigatório com o AsNoTracking

// db.SaveChanges();
