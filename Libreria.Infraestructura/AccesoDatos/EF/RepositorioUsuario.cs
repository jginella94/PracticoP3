
using Libreria.LogicaNegocio.Entidades;
using System.Linq.Expressions;

namespace Libreria.Infraestructura.AccesoDatos.EF
{
    public class RepositorioUsuario
    {

        private LibreriaContext _context = new LibreriaContext();

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios;
        }

        public bool ExisteUsuario(Usuario usuario)
        {
            return false;
        }


        public void Delete(int id)
        {
            Usuario usuario = GetById(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public Usuario GetById(int id) 
        {
            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario == null) {
                throw new Exception($"No se encontro el usuario {id}");
            }
            return usuario;
        }

    }
}
