using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clase10.Data;
using Clase10.Models;

namespace Clase10.Controllers
{
    public class CiudadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CiudadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ciudades
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ciudades.Include(c => c.Pais);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Ciudades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades
                .Include(c => c.Pais)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // GET: Ciudades/Create
        public IActionResult Create()
        {
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre");
            return View();
        }

        // POST: Ciudades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,PaisId")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciudad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", ciudad.PaisId);
            return View(ciudad);
        }

        // GET: Ciudades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", ciudad.PaisId);
            return View(ciudad);
        }

        // POST: Ciudades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,PaisId")] Ciudad ciudad)
        {
            if (id != ciudad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciudad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CiudadExists(ciudad.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaisId"] = new SelectList(_context.Paises, "Id", "Nombre", ciudad.PaisId);
            return View(ciudad);
        }

        // GET: Ciudades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades
                .Include(c => c.Pais)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // POST: Ciudades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad != null)
            {
                _context.Ciudades.Remove(ciudad);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CiudadExists(int id)
        {
            return _context.Ciudades.Any(e => e.Id == id);
        }
    }
}
