using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Librearia.LogicaNegocio.Vo;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class EditarUsuario : IEditar<DtoUsuarioAlta>
    {
        private IRepositorioUsuario _repo;

        public EditarUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Ejecutar(int id, DtoUsuarioAlta dtoUsuario)
        {
            if (dtoUsuario == null)
            {
                throw new Exception("El usuario no puede ser nulo");
            }
            _repo.GetById(id);
            // Mapper DtoUsuario -> Usuario
            Usuario usuario = new Usuario(new VoNombre(dtoUsuario.Nombre), dtoUsuario.Mail, dtoUsuario.Rol, dtoUsuario.Telefono);
            _repo.Update(id, usuario);
        }

    }
}
