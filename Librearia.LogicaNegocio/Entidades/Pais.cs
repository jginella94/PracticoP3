
namespace Libreria.LogicaNegocio.Entidades
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; private set; }
        public int CantidadHabitantes { get; private set; }

        public List<Autor> Autores { get; private set; }

    }
}
