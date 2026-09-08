

namespace Libreria.LogicaNegocio.Entidades
{
    public class Revista : Publicacion
    {

        public int Numero { get; private set; }
        public int Anio { get; private set; }
        public string? TablaContenido { get; private set; }

    }
}
