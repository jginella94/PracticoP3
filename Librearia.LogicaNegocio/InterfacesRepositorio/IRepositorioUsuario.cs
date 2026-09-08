

using Libreria.LogicaNegocio.Entidades;

namespace Librearia.LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioUsuario : IRepositorioAdd<Usuario>
    {
        IEnumerable<Usuario> GetAll();
        bool ExisteUsuario(Usuario usuario);
        void Delete(int id);
        Usuario GetById(int id);
        void Update(int id, Usuario usuario);
    }
}
