using Clase_Layouts_PV_Valid.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_Layouts_PV_Valid.Controllers
{
    public class UsuariosController : Controller
    {
        static List<Usuario> _listaUsuarios { get; set; } = new List<Usuario>();



        public IActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Nuevo(Models.Usuario usuario)
        {
            if (ModelState.IsValid)
            {
            _listaUsuarios.Add(usuario); 
            return RedirectToAction(nameof(Lista));
            }
            return View(usuario);
        }
        public IActionResult Lista()
        {
            return View(_listaUsuarios);
        }
    }
}
