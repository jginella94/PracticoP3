using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(DtoLogin login)
        {
            if (login.Mail == "admin" && login.Password == "123")
            {
                //return RedirectToAction("Index", "Usuario");

                HttpContext.Session.SetString("User", login.Mail);
                HttpContext.Session.SetString("Rol", "admin");
                return Redirect("/Usuario/Index");
            }
            ViewBag.ErrorMessage = "Nombre de usuario o contraseña incorrectos.";
            return View("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
