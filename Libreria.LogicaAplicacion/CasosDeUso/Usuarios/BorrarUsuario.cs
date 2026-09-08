using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class BorrarUsuario : IBorrar<Usuario>
    {
        private IRepositorioUsuario _repo;

        public BorrarUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Ejecutar(int id)
        {
            _repo.Delete(id);
        }
    }
}
