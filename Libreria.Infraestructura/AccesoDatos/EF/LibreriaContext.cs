using Librearia.LogicaNegocio.Entidades;
using Libreria.Infraestructura.AccesoDatos.EF.Config;
using Libreria.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Infraestructura.AccesoDatos.EF
{
    public class LibreriaContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Pais> Paises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=libreriaN3C;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
        }

    }
}
