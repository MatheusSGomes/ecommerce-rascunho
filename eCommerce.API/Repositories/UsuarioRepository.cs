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
        CriarVinculoDoUsuarioComDepartamento(usuario);

        _db.Add(usuario);
        _db.SaveChanges();
    }

    public void Update(Usuario usuario)
    {
        ExcluirVinculoDoUsuarioComDepartamento(usuario);
        CriarVinculoDoUsuarioComDepartamento(usuario);

        _db.Update(usuario);
        _db.SaveChanges();
    }
    
    public void Delete(int id)
    {
        var usuario = Get(id);
        _db.Remove(usuario);
        _db.SaveChanges();
    }

    private void CriarVinculoDoUsuarioComDepartamento(Usuario usuario)
    {
        if (usuario.Departamentos != null)
        {
            var departamentos = usuario.Departamentos;
            usuario.Departamentos = new List<Departamento>(); // limpa a lista

            foreach (var departamento in departamentos)
            {
                if (departamento.Id > 0)
                {
                    // Add Refência registro do banco.
                    usuario.Departamentos.Add(_db.Departamentos.Find(departamento.Id));
                }
                else
                {
                    // Add novo registro. Referência não existe no SGBD.
                    usuario.Departamentos.Add(departamento);
                }
            }
        }
    }

    private void ExcluirVinculoDoUsuarioComDepartamento(Usuario usuario)
    {
        var usuarioDoBanco = _db.Usuarios
            .Include(usr => usr.Departamentos)
            .FirstOrDefault(usr => usr.Id == usuario.Id);

        foreach (var departamento in usuarioDoBanco!.Departamentos!)
        {
            usuarioDoBanco.Departamentos.Remove(departamento);
        }

        _db.SaveChanges();
        _db.ChangeTracker.Clear();
    }
}
