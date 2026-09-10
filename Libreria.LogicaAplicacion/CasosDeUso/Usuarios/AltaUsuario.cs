using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Librearia.LogicaNegocio.Vo;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class AltaUsuario : IAlta<DtoUsuarioAlta>
    {
        private IRepositorioUsuario _repo;

        public AltaUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Ejecutar(DtoUsuarioAlta dtoUsuario)
        {
            if (dtoUsuario == null)
            {
                throw new Exception("Informacion inválida");
            }
            // Mapper DtoUsuario -> Usuario
            Usuario usuario = new Usuario(new VoNombre(dtoUsuario.Nombre), dtoUsuario.Mail, dtoUsuario.Rol, dtoUsuario.Telefono);
            if (_repo.ExisteUsuario(usuario))
            {
                throw new Exception("Ya existe el usuario");
            }
            _repo.Add(usuario);
        }
    }
}
