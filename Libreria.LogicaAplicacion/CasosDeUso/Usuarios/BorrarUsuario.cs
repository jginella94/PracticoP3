using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class BorrarUsuario(IRepositorioUsuario _repo) : IBorrar<DtoUsuarioAlta>
    {

        public void Ejecutar(int id)
        {
            _repo.Delete(id);
        }
    }
}
