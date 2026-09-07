
using System.Text.RegularExpressions;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; private set; }
        public string Mail { get; private set; }
        public string Rol { get; private set; }
        public string Telefono { get; private set; }

        private Usuario() { }
        public Usuario(string nombre, string mail, string rol, string telefono)
        {
            Nombre = nombre;
            Mail = mail;
            Rol = rol;
            Telefono = telefono;
            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre esta vacio");
            }
            // uso expresiones regulares para la validacion
            if (!Regex.IsMatch(Telefono, @"^(099|095)[0-9]{6}$"))
            {
                // Celular inválido
                Console.WriteLine("Ingrese un celular válido. Ejemplo: 099123456");
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

