
namespace Libreria.LogicaNegocio.Entidades
{
    public class Tema 
    {
        public int Id { get; set; }

        public string Nombre { get; private set; }

        public string Descripcion { get; private set; }

        public List<Publicacion> MisPublicaciones { get; private set; }

    }
}
