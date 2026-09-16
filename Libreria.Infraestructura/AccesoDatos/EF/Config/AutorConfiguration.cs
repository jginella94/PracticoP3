using Libreria.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Infraestructura.AccesoDatos.EF.Config
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Autor> builder)
        {

        }
    }
}
