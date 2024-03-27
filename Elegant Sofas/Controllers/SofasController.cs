using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Elegant_Sofas.Data;
using Elegant_Sofas.Models;

namespace Elegant_Sofas.Controllers
{
    public class SofasController : Controller
    {
        private readonly Elegant_SofasContext _context;

        public SofasController(Elegant_SofasContext context)
        {
            _context = context;
        }

        // GET: Sofas
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Sofas == null)
            {
                return Problem("Entity set 'Elegant_SofasContext.Sofas'  is null.");
            }

            var sofas = from m in _context.Sofas
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                sofas = sofas.Where(s => s.Product!.Contains(searchString));
            }

            return View(await sofas.ToListAsync());
        }

        // GET: Sofas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sofas = await _context.Sofas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sofas == null)
            {
                return NotFound();
            }

            return View(sofas);
        }

        // GET: Sofas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sofas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Product,Color,Material,Price,Rating")] Sofas sofas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sofas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sofas);
        }

        // GET: Sofas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sofas = await _context.Sofas.FindAsync(id);
            if (sofas == null)
            {
                return NotFound();
            }
            return View(sofas);
        }

        // POST: Sofas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Product,Color,Material,Price, Rating")] Sofas sofas)
        {
            if (id != sofas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sofas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SofasExists(sofas.Id))
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
            return View(sofas);
        }

        // GET: Sofas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sofas = await _context.Sofas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sofas == null)
            {
                return NotFound();
            }

            return View(sofas);
        }

        // POST: Sofas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sofas = await _context.Sofas.FindAsync(id);
            if (sofas != null)
            {
                _context.Sofas.Remove(sofas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SofasExists(int id)
        {
            return _context.Sofas.Any(e => e.Id == id);
        }
    }
}
