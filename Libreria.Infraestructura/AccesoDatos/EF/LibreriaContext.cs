using Libreria.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.Infraestructura.AccesoDatos.EF
{
    public class LibreriaContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=libreriaN3C;Integrated Security=True;");
        }
    }
}
