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
                new VoMail(dtoUsuario.Mail),
                dtoUsuario.Rol,
                new VoTelefono(dtoUsuario.Telefono)
                );
        }

        // Aca se usan parametros nominados
        public static DtoUsuarioListado DesdeEntidad(Usuario usuario)
        {
            return new DtoUsuarioListado(
                Id: usuario.Id,
                Nombre: usuario.Nombre.Value,
                Mail: usuario.Mail.Value,
                Rol: usuario.Rol,
                Telefono: usuario.Telefono.Value
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
