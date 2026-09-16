using Libreria.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Libreria.Infraestructura.AccesoDatos.EF.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Estoy configrando el VONombre a la columna de la tabla
            builder.OwnsOne(usuario => usuario.Nombre, VoNombre =>
            {
                VoNombre.Property(vo => vo.Value).HasColumnName("Nombre");
            });

            builder.OwnsOne(usuario => usuario.Telefono, VoTelefono =>
            {
                VoTelefono.Property(vo => vo.Value).HasColumnName("Telefono");
            });

            builder.OwnsOne(usuario => usuario.Mail, VoMail =>
            {
                VoMail.Property(vo => vo.Value).HasColumnName("Mail");
            });
        }
    }
}