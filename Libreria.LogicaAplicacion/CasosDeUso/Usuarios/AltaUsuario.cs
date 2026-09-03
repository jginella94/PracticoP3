using Libreria.Infraestructura.AccesoDatos.EF;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class AltaUsuario
    {
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
