using Librearia.LogicaNegocio.Vo;
using Libreria.LogicaNegocio.Entidades;

namespace Librearia.LogicaNegocio.Entidades
{
    public class Admin : Usuario
    {
        public int NroFunc { get; private set; }

        private Admin() { }
        public Admin(int Nro, VoNombre nombre, VoMail mail, string rol, VoTelefono telefono) : base(nombre, mail, rol, telefono)
        {
            NroFunc = Nro;
        }
    }
}
