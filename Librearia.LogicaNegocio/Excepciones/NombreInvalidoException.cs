namespace Librearia.LogicaNegocio.Excepciones
{
    public class NombreInvalidoException : LogicaNegocioException
    {
        public NombreInvalidoException()
        {
        }

        public NombreInvalidoException(string? message) : base(message)
        {
        }
    }
}
