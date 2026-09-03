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
        private VerUsuario _ver = new VerUsuario();


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
                var usuario = _ver.Ejecutar(id);
                if (usuario == null)
                    return RedirectToAction("Index");
                return View(usuario);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _borrar.Ejecutar(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }


        public ActionResult Details(int id)
        {
            try
            {
                var usuario = _ver.Ejecutar(id);
                return View(usuario);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }


    }
}
