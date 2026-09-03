using Libreria.Infraestructura.AccesoDatos.EF;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class VerUsuario
    {
        private RepositorioUsuario _repo = new RepositorioUsuario();

        public Usuario Ejecutar(int id)
        {
            return _repo.GetById(id);
        }
    }
}
