using Libreria.Infraestructura.AccesoDatos.Memoria;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class AltaUsuario
    {
        // esto esta acplcado. El cu sabe como se hace rl repositorio
        private RepositorioUsuario _repo = new RepositorioUsuario();

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
