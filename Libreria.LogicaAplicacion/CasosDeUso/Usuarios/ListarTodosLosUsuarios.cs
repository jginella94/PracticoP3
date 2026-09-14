using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class ListarTodosLosUsuarios : IListarTodos<DtoUsuarioListado>
    {
        private IRepositorioUsuario _repo;

        public ListarTodosLosUsuarios(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public IEnumerable<DtoUsuarioListado> Ejecutar()
        {
            // Maper List<usuario> -> List<usuarioDto>
            List<DtoUsuarioListado> aux = new List<DtoUsuarioListado>();
            foreach (Usuario unU in _repo.GetAll())
            {
                DtoUsuarioListado dto = new DtoUsuarioListado(unU.Id, unU.Nombre.Value, unU.Mail, unU.Rol, unU.Telefono);
                aux.Add(dto);
            }
            return aux;
        }

    }
}
