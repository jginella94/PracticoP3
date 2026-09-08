using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class EditarUsuario : IEditar<Usuario>
    {
        private IRepositorioUsuario _repo;

        public EditarUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Ejecutar(int id, Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("El usuario no puede ser nulo");
            }
            _repo.GetById(id);
            _repo.Update(id, usuario);
        }

    }
}
