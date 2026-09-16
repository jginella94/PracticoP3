using Librearia.LogicaNegocio.Excepciones;
using System.Text.RegularExpressions;

namespace Librearia.LogicaNegocio.Vo
{
    public record VoTelefono
    {
        public string Value { get; private set; }
        public VoTelefono(string value)
        {
            Value = value;
            Validar();
        }
        private void Validar()
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new TelefonoInvalidoException("El teléfono está vacío.");
            }
            if (!Regex.IsMatch(Value, @"^(099|095)[0-9]{6}$"))
            {
                throw new TelefonoInvalidoException("Ingrese un celular válido. Ejemplo: 099123456");
            }
        }

    }
}
