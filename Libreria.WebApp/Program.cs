using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Librearia.LogicaNegocio.InterfacesRepositorio;
using Libreria.Infraestructura.AccesoDatos.EF;
using Libreria.LogicaAplicacion.CasosDeUso.Usuarios;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Inyeccion de dependencia de los repositorios
            builder.Services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();


            // Inyeccion de dependencia de los casos de uso
            builder.Services.AddScoped<IAlta<Usuario>, AltaUsuario>();
            builder.Services.AddScoped<IListarTodos<Usuario>, ListarTodosLosUsuarios>();
            builder.Services.AddScoped<IBorrar<Usuario>, BorrarUsuario>();
            builder.Services.AddScoped<IVer<Usuario>, VerUsuario>();
            builder.Services.AddScoped<IEditar<Usuario>, EditarUsuario>();

            // Inyeccion de dependencia de la base de datos
            builder.Services.AddDbContext<LibreriaContext>();



            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Usuario}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
