using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaAplicacion.Mapper;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class ListarTodosLosUsuarios(IRepositorioUsuario _repo) : IListarTodos<DtoUsuarioListado>
    {
        public IEnumerable<DtoUsuarioListado> Ejecutar()
        {
            return UsuarioMapper.ListadoDto(_repo.GetAll());
        }

    }
}
