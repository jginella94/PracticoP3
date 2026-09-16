namespace Librearia.LogicaNegocio.Excepciones
{
    public class TelefonoInvalidoException : LogicaNegocioException
    {
        public TelefonoInvalidoException()
        {
        }

        public TelefonoInvalidoException(string? message) : base(message)
        {
        }
    }
}
