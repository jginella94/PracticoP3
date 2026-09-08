using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class ListarTodosLosUsuarios : IListarTodos<Usuario>
    {
        private IRepositorioUsuario _repo;

        public ListarTodosLosUsuarios(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public IEnumerable<Usuario> Ejecutar()
        {
            return _repo.GetAll();
        }

    }
}
