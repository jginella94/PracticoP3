using Librearia.LogicaNegocio.Excepciones;

namespace Librearia.LogicaNegocio.Vo
{
    public record VoMail
    {
        public string Value { get; private set; }
        public VoMail(string value)
        {
            Value = value;
            Validar();
        }
        private void Validar()
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new MailInvalidoException("El mail está vacío.");
            }
            if (!Value.Contains("@"))
            {
                throw new MailInvalidoException("El mail no es válido.");
            }
        }
    }
}
