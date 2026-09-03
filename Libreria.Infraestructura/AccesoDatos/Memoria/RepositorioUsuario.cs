using Libreria.LogicaNegocio.Entidades;

namespace Libreria.Infraestructura.AccesoDatos.Memoria
{
    public class RepositorioUsuario
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

        // getById
        // delele
        // update
        // geyByName
    }
}
