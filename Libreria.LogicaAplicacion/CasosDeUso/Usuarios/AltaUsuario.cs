using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaAplicacion.Mapper;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class AltaUsuario(IRepositorioUsuario _repo) : IAlta<DtoUsuarioAlta>
    {

        public void Ejecutar(DtoUsuarioAlta dtoUsuario)
        {
            if (dtoUsuario == null)
            {
                throw new Exception("Informacion inválida");
            }
            Usuario usuario = UsuarioMapper.DesdeDto(dtoUsuario);
            if (_repo.ExisteUsuario(usuario))
            {
                throw new Exception("Ya existe el usuario");
            }
            _repo.Add(usuario);
        }
    }
}
