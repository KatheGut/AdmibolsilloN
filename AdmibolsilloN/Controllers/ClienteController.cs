using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AdmibolsilloN.Models.ViewModels; // Cambiar al namespace de tus modelos
using AdmibolsilloN.Data;

namespace AdmibolsilloN.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Acción para cargar el Dashboard del cliente
        public ActionResult DashboardCliente()
        {
            // Verificar si el usuario está autenticado
            if (Session["id"] == null)
            {
                return RedirectToAction("Ingresar", "Autenticacion");
            }

            int userId = (int)Session["id"];
            var usuario = _context.Usuario.SingleOrDefault(u => u.Id == userId);

            if (usuario == null)
            {
                TempData["ErrorMessage"] = "Usuario no encontrado.";
                return RedirectToAction("Ingresar", "Autenticacion");
            }

            // Obtener datos para el Dashboard
            var viewModel = new DashboardClienteViewModel
            {
                Usuario = usuario,
                CantidadIngresos = _context.Ingresos.Count(i => i.UsuarioId == userId),
                CantidadPlanAhorro = _context.PlanesAhorro.Count(p => p.UsuarioId == userId),
                CantidadGastos = _context.Gastos.Count(g => g.UsuarioId == userId)
            };

            return View(viewModel);
        }

        // Acción para manejar el formulario
        [HttpPost]
        public ActionResult ActualizarPerfil(DashboardClienteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Datos inválidos. Por favor, verifica e intenta nuevamente.";
                return RedirectToAction("DashboardCliente");
            }

            var usuario = _context.Usuario.SingleOrDefault(u => u.Id == model.Usuario.Id);

            if (usuario == null)
            {
                TempData["ErrorMessage"] = "Usuario no encontrado.";
                return RedirectToAction("DashboardCliente");
            }

            // Actualizar la información del usuario
            usuario.Nombre = model.Usuario.Nombre;
            usuario.Apellido = model.Usuario.Apellido;
            usuario.Correo = model.Usuario.Correo;
            usuario.Celular = model.Usuario.Celular;

            _context.SaveChanges();

            TempData["SuccessMessage"] = "Información actualizada correctamente.";
            return RedirectToAction("DashboardCliente");
        }
    }
}
