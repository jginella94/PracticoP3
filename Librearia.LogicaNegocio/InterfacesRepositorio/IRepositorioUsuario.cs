
using Libreria.LogicaNegocio.Entidades;

namespace Librearia.LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioUsuario :
        IAdd<Usuario>,
        IDelete<Usuario>,
        IGetAll<Usuario>,
        IGetById<Usuario>,
        IUpdate<Usuario>
    {
        bool ExisteUsuario(Usuario usuario);
    }
}
