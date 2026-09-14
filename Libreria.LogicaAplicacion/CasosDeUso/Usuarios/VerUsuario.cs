using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class VerUsuario : IVer<DtoUsuarioListado>
    {
        private IRepositorioUsuario _repo;

        public VerUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public DtoUsuarioListado Ejecutar(int id)
        {
            // Maper usuario -> usuarioDto
            Usuario unU = _repo.GetById(id);
            DtoUsuarioListado dto = new DtoUsuarioListado(unU.Id, unU.Nombre.Value, unU.Mail, unU.Rol, unU.Telefono);
            return dto;
        }
    }
}
