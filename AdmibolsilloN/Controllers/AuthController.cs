using AdmibolsilloN.Data;
using AdmibolsilloN.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdmibolsilloN.Controllers
{
   

    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo, string contrasena)
        {
            var user = _context.Usuario
                .FirstOrDefault(u => u.Correo == correo && u.Contrasena == contrasena);

            if (user != null)
            {
                if (user.IdTipoUsuario == 1)
                    return RedirectToAction("AdminDashboard", "Account");
                if (user.IdTipoUsuario == 2)
                    return RedirectToAction("AdvisorDashboard", "Account");
                if (user.IdTipoUsuario == 3)
                    return RedirectToAction("ClientDashboard", "Account");
            }

            ViewBag.Error = "Credenciales inválidas";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Usuario usuario)
        {
            usuario.IdTipoUsuario = 3; // Solo se registran clientes
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
    }
}


