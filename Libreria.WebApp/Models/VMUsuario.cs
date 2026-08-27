using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Libreria.WebApp.Models
{
    public class VMUsuario
    {
        public int Id { get; set; }
        
        [DisplayName("Ingrese su nombre y apellido")]
        [Required(ErrorMessage = "Debe ingresar el nombre")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string Nombre { get; set; }


        [EmailAddress]
        public string Mail { get; set; }
        
        public string Rol { get; set; }


        [RegularExpression(@"^(099|095|094)[0-9]{6}$", ErrorMessage = "Ingrese un celular válido. Ejemplo: 099123456")]
        public string Telefono { get; set; }
    }
}
