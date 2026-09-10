using Librearia.LogicaNegocio.Excepciones;
using Librearia.LogicaNegocio.InterfacesLogicaAplicacion;
using Libreria.LogicaAplicacion.Dtos.Usuarios;
using Libreria.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private IListarTodos<DtoUsuarioListado> _getall;
        private IAlta<DtoUsuarioAlta> _add;
        private IBorrar<DtoUsuarioAlta> _borrar;
        private IVer<DtoUsuarioListado> _ver;
        private IEditar<DtoUsuarioAlta> _editar;

        public UsuarioController(
            IAlta<DtoUsuarioAlta> add,
            IListarTodos<DtoUsuarioListado> getall,
            IBorrar<DtoUsuarioAlta> borrar,
            IVer<DtoUsuarioListado> ver,
            IEditar<DtoUsuarioAlta> editar
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
            });
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
