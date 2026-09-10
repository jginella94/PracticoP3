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
        }
    }
}

