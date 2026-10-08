using Libreria.Infraestructura.AccesoDatos.EF;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.Infraestructura.AccesoDatos
{
    public class SeedData
    {
        private LibreriaContext _context;

        public SeedData(LibreriaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Autores.Any())
                CreateAutores();
        }


        private void CreateAutores()
        {
            Autor autor1 = new Autor(
                "Gabriel García Márquez",
                new DateTime(1927, 3, 6),
                new DateTime(2014, 4, 17),
                "Aracataca, Colombia",
                "gabriel@example.com",
                12345,
                _context.Paises.First()
                );
            _context.Autores.Add(autor1);

            autor1 = new Autor(
                "Ana Márquez",
                new DateTime(1927, 3, 6),
                new DateTime(2014, 4, 17),
                "Aracataca, Colombia",
                "gabriel@example.com",
                333333,
                _context.Paises.First()
                );
            _context.Autores.Add(autor1);


            autor1 = new Autor(
               "Pedro García Márquez",
               new DateTime(1927, 3, 6),
               new DateTime(2014, 4, 17),
               "Aracataca, Colombia",
               "gabriel@example.com",
               333333,
               _context.Paises.First()
               );
            _context.Autores.Add(autor1);

            _context.SaveChanges();

        }


    }
}
