

namespace Libreria.LogicaNegocio.Entidades
{
    public abstract class Publicacion
    {
        public int Id { get; set; }
        public DateTime FechaPublicado { get; private set; }
        public int CantidadPaginas { get; private set; }
        public decimal PrecioSugerido { get; private set; }

        public int Stock { get; private set; }

        public Autor MiAutor { get; private set; }
        public Pais MiPais { get; private set; }
        public Tema? MiTema { get; set; }
    }
}
