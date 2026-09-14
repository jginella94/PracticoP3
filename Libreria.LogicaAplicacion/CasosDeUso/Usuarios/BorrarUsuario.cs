using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class BorrarUsuario : IBorrar<DtoUsuarioAlta>
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
