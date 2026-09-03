using Libreria.Infraestructura.AccesoDatos.EF;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class BorrarUsuario
    {
        private RepositorioUsuario _repo = new RepositorioUsuario();

        public void Ejecutar(int id)
        {
            _repo.Delete(id);
        }
    }
}
