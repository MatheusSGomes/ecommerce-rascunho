using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly eCommerceContext _db;

    public UsuarioRepository(eCommerceContext db)
    {
        _db = db;
    }

    public List<Usuario> Get()
    {
        return _db.Usuarios
            .Include(usuario => usuario.Contato)
            .OrderBy(a => a.Id).ToList();
    }

    public Usuario Get(int id)
    {
        return _db.Usuarios
            .Include(usuario => usuario.Contato)
            .Include(usuario => usuario.EnderecosEntrega)
            .Include(usuario => usuario.Departamentos)
            .FirstOrDefault(usuario => usuario.Id == id)!;
    }

    public void Add(Usuario usuario)
    {
        _db.Add(usuario);
        _db.SaveChanges();
    }

    public void Update(Usuario usuario)
    {
        _db.Update(usuario);
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var usuario = Get(id);
        _db.Remove(usuario);
        _db.SaveChanges();
    }
}
