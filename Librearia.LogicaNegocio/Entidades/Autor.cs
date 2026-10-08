
namespace Libreria.LogicaNegocio.Entidades
{
    public class Autor
    {

        public int Id { get; set; }
        public string Nombre { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public DateTime FechaDefuncion { get; private set; }
        public string Direccion { get; private set; }
        public string Email { get; private set; }
        public int NumeroReferencia { get; private set; }

        public Pais MiPais { get; private set; }
        public int MiPaisId { get; private set; }

        //public List<Telefono>? MisTelefonos { get; private set; }
        //public List<Publicacion> MisPublicaciones { get; private set; }

        private Autor() { }

        public Autor(string nombre, DateTime fechaNacimiento, DateTime fechaDefuncion, string direccion, string email, int numeroReferencia, Pais pais)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            FechaDefuncion = fechaDefuncion;
            Direccion = direccion;
            Email = email;
            NumeroReferencia = numeroReferencia;
            MiPais = pais;
        }
    }
}
