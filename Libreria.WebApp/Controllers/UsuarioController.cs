using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Libreria.LogicaNegocio.Entidades;
using Libreria.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private IListarTodos<Usuario> _getall;
        private IAlta<Usuario> _add;
        private IBorrar<Usuario> _borrar;
        private IVer<Usuario> _ver;
        private IEditar<Usuario> _editar;

        public UsuarioController(
            IAlta<Usuario> add,
            IListarTodos<Usuario> getall,
            IBorrar<Usuario> borrar,
            IVer<Usuario> ver,
            IEditar<Usuario> editar
        )
        {
            _add = add;
            _getall = getall;
            _borrar = borrar;
            _ver = ver;
            _editar = editar;
        }


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
                {
                    return RedirectToAction("Index");
                }
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


        public IActionResult Edit(int id)
        {
            Usuario usuario = _ver.Ejecutar(id);
            if (usuario == null)
            {
                return RedirectToAction("index");
            }
            return View(new VMUsuario()
            {
                Nombre = usuario.Nombre,
                Mail = usuario.Mail,
                Rol = usuario.Rol,
                Telefono = usuario.Telefono
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, VMUsuario vMUsuario)
        {

            try
            {
                _editar.Ejecutar(id, new Usuario(vMUsuario.Nombre, vMUsuario.Mail, vMUsuario.Rol, vMUsuario.Telefono));
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {

                ViewBag.Mensaje = e.Message;
                return View(vMUsuario);
            }
        }

    }
}
