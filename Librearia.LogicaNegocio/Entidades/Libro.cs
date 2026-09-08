

namespace Libreria.LogicaNegocio.Entidades
{
    public class Libro : Publicacion
    {
        public string ISBN { get; private set; }
        public string Titulo { get; private set; }
    }

}
