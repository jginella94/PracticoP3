
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.Infraestructura.AccesoDatos.EF
{
    public class RepositorioUsuario : IRepositorioUsuario
    {

        private LibreriaContext _context;

        public RepositorioUsuario(LibreriaContext context)
        {
            _context = context;
        }


        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios
                .OrderBy(u => u.Nombre.Value)
                .ToList();
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
            Usuario usuario = _context.Usuarios
                        .FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                throw new Exception($"No se encontro el usuario {id}");
            }
            return usuario;
        }

        public void Update(int id, Usuario usuario)
        {
            Usuario unUsuario = GetById(id);
            unUsuario.Modificar(usuario);
            _context.Usuarios.Update(unUsuario);
            _context.SaveChanges();
        }


    }
}
