using Libreria.Infraestructura.AccesoDatos.EF;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosDeUso.Usuarios
{
    public class EditarUsuario
    {
        private RepositorioUsuario _repo = new RepositorioUsuario();

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
