using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class AltaUsuario : IAlta<Usuario>
    {
        private IRepositorioUsuario _repo;

        public AltaUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Ejecutar(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("Informacion inválida");
            }
            if (_repo.ExisteUsuario(usuario))
            {
                throw new Exception("Ya existe el usuario");
            }
            _repo.Add(usuario);
        }
    }
}
