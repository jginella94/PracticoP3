using Librearia.LogicaNegocio.Vo;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.Mapper
{
    public static class UsuarioMapper
    {
        public static Usuario DesdeDto(DtoUsuarioAlta dtoUsuario)
        {
            return new Usuario(
                new VoNombre(dtoUsuario.Nombre),
                dtoUsuario.Mail,
                dtoUsuario.Rol,
                dtoUsuario.Telefono
                );
        }

        public static DtoUsuarioListado DesdeEntidad(Usuario usuario)
        {
            return new DtoUsuarioListado(
                usuario.Id,
                usuario.Nombre.Value,
                usuario.Mail,
                usuario.Rol,
                usuario.Telefono
                );
        }

        public static IEnumerable<DtoUsuarioListado> ListadoDto(IEnumerable<Usuario> usuarios)
        {
            List<DtoUsuarioListado> aux = new List<DtoUsuarioListado>();
            foreach (Usuario usuario in usuarios)
            {
                DtoUsuarioListado dto = DesdeEntidad(usuario);
                aux.Add(dto);
            }
            return aux;
        }

    }
}
