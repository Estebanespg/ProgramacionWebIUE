using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Seguimiento3.Models;

namespace Seguimiento3.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Asistente());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(Asistente asistente)
    {
        if (!ModelState.IsValid)
        {
            return View(asistente);
        }
        return View("Mensaje", asistente);
    }
}
