using Libreria.Infraestructura.AccesoDatos.EF;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class ListarTodosLosUsuarios
    {
        private RepositorioUsuario _repo = new RepositorioUsuario();

        public IEnumerable<Usuario> Ejecutar()
        {
            return _repo.GetAll();
        }

    }
}
