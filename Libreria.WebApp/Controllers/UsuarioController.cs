using Libreria.LogicaAplicacion.CasosDeUso.Usuarios;
using Libreria.LogicaNegocio.Entidades;
using Libreria.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private ListarTodosLosUsuarios _getall = new ListarTodosLosUsuarios();
        private AltaUsuario _add = new AltaUsuario();
        private BorrarUsuario _borrar = new BorrarUsuario();


        public IActionResult Index()
        {
            return View(_getall.Ejecutar());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VMUsuario vMUsuario)
        {
            try
            {
                _add.Ejecutar(new Usuario(vMUsuario.Nombre, vMUsuario.Mail, vMUsuario.Rol, vMUsuario.Telefono));
                return RedirectToAction("index");
            }
            catch (Exception e)
            {

                ViewBag.Mensaje = e.Message;
                return View(vMUsuario);
            }
        }


        public ActionResult Delete(int id)
        {
            try
            {
                _borrar.Ejecutar(id);
                return RedirectToAction("index");

            }
            catch (Exception)
            {
                return RedirectToAction("index");
            }
        }

    }
}
