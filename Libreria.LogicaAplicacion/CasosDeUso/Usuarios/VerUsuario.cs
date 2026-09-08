using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class VerUsuario : IVer<Usuario>
    {
        private IRepositorioUsuario _repo;

        public VerUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public Usuario Ejecutar(int id)
        {
            return _repo.GetById(id);
        }
    }
}
