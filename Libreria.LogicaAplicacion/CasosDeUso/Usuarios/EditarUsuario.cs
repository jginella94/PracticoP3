using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaAplicacion.Mapper;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class EditarUsuario(IRepositorioUsuario _repo) : IEditar<DtoUsuarioAlta>
    {

        public void Ejecutar(int id, DtoUsuarioAlta dtoUsuario)
        {
            if (dtoUsuario == null)
            {
                throw new Exception("El usuario no puede ser nulo");
            }
            _repo.GetById(id);
            _repo.Update(id, UsuarioMapper.DesdeDto(dtoUsuario));
        }
    }
}
