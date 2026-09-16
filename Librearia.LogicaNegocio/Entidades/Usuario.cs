using Librearia.LogicaNegocio.Excepciones;
using Librearia.LogicaNegocio.Vo;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public VoNombre Nombre { get; private set; }
        public VoMail Mail { get; private set; }
        public string Rol { get; private set; }
        public VoTelefono Telefono { get; private set; }

        private Usuario() { }
        public Usuario(VoNombre nombre, VoMail mail, string rol, VoTelefono telefono)
        {
            Nombre = nombre;
            Mail = mail;
            Rol = rol;
            Telefono = telefono;
            Validar();
        }

        private void Validar()
        {
            if (Nombre == null)
            {
                throw new NombreInvalidoException("El nombre es inválido.");
            }
            if (Telefono == null)
            {
                throw new TelefonoInvalidoException("El teléfono es inválido.");
            }
            if (Mail == null)
            {
                throw new MailInvalidoException("El mail es inválido.");
            }
        }

        public override bool Equals(object? obj)
        {
            Usuario u = obj as Usuario;
            return Nombre == u.Nombre;
        }

        public void Modificar(Usuario usuario)
        {
            Nombre = usuario.Nombre;
            Mail = usuario.Mail;
            Rol = usuario.Rol;
            Telefono = usuario.Telefono;
            Validar();
        }
    }

}

