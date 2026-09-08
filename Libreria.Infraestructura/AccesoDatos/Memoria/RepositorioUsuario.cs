using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.Infraestructura.AccesoDatos.Memoria
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private static List<Usuario> _usuarios = new List<Usuario>();

        public void Add(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarios;
        }

        public bool ExisteUsuario(Usuario usuario)
        {
            return _usuarios.Contains(usuario);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Usuario usuario)
        {
            throw new NotImplementedException();
        }

        // getById
        // delele
        // update
        // geyByName
    }
}
