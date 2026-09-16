namespace Librearia.LogicaNegocio.Excepciones
{
    public class MailInvalidoException : LogicaNegocioException
    {
        public MailInvalidoException()
        {
        }

        public MailInvalidoException(string? message) : base(message)
        {
        }
    }
}
