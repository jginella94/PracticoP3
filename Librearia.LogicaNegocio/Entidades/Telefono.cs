
namespace Libreria.LogicaNegocio.Entidades
{
    public class Telefono
    {
        public int Id { get; set; }
        public int? CodigoArea { get; private set; }
        public int? Numero { get; private set; }
        public string? Descripcion { get; private set; }

    }
}
