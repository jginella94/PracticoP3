using Libreria.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Infraestructura.AccesoDatos.EF.Config
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pais> builder)
        {

        }
    }
}
