using Librearia.LogicaNegocio.Excepciones;
using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.WebApp.Filtros;
using Libreria.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.WebApp.Controllers
{
    [Admin]
    public class UsuarioController(
        IListarTodos<DtoUsuarioListado> _getall,
        IAlta<DtoUsuarioAlta> _add,
        IBorrar<DtoUsuarioAlta> _borrar,
        IVer<DtoUsuarioListado> _ver,
        IEditar<DtoUsuarioAlta> _editar
        ) : Controller
    {

        //[AllowAnonymous]
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
                _add.Ejecutar(new DtoUsuarioAlta(vMUsuario.Nombre, vMUsuario.Mail, vMUsuario.Rol, vMUsuario.Telefono));
                return RedirectToAction("index");
            }
            catch (LogicaNegocioException e)
            {
                ViewBag.Mensaje = e.Message;
            }
            catch (Exception e)
            {
                ViewBag.Mensaje = e.Message;
            }
            return View(vMUsuario);
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
            DtoUsuarioListado dto = _ver.Ejecutar(id);
            if (dto == null)
            {
                return RedirectToAction("index");
            }
            return View(new VMUsuario()
            {
                Nombre = dto.Nombre,
                Mail = dto.Mail,
                Rol = dto.Rol,
                Telefono = dto.Telefono
            }
            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, VMUsuario vMUsuario)
        {

            try
            {
                _editar.Ejecutar(id, new DtoUsuarioAlta(vMUsuario.Nombre, vMUsuario.Mail, vMUsuario.Rol, vMUsuario.Telefono));
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
