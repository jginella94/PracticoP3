using Librearia.LogicaNegocio.Excepciones;

namespace Librearia.LogicaNegocio.Vo
{
    public record VoNombre
    {
        public string Value { get; private set; }

        public VoNombre(string value)
        {
            Value = value;
            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new NombreInvalidoException("Navnet er tomt.");
            }
        }

    }
}
