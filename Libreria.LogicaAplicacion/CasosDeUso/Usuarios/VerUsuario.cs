using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaAplicacion.Mapper;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class VerUsuario(IRepositorioUsuario _repo) : IVer<DtoUsuarioListado>
    {

        public DtoUsuarioListado Ejecutar(int id)
        {
            return UsuarioMapper.DesdeEntidad(_repo.GetById(id));
        }
    }
}
