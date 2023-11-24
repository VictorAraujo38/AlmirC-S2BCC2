using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlmirTrabs.Models;

namespace AlmirTrabs.Controllers
{
    public class RacoesController : Controller
    {

        private readonly Contexto _context;

        public RacoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Racoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Racoes.ToListAsync());
        }

        // GET: Racoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Racoes == null)
            {
                return NotFound();
            }

            var Racoes = await _context.Racoes
                .FirstOrDefaultAsync(m => m.id == id);
            if (Racoes == null)
            {
                return NotFound();
            }

            return View(Racoes);
        }

        // GET: Racoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Racoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao,patrimonio")] Racoes Racoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Racoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Racoes);
        }

        // GET: Racoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Racoes == null)
            {
                return NotFound();
            }

            var Racoes = await _context.Racoes.FindAsync(id);
            if (Racoes == null)
            {
                return NotFound();
            }
            return View(Racoes);
        }

        // POST: Racoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descricao,patrimonio")] Racoes Racoes)
        {
            if (id != Racoes.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Racoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RacoesExists(Racoes.id))
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
            return View(Racoes);
        }

        // GET: Racoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Racoes == null)
            {
                return NotFound();
            }

            var Racoes = await _context.Racoes
                .FirstOrDefaultAsync(m => m.id == id);
            if (Racoes == null)
            {
                return NotFound();
            }

            return View(Racoes);
        }

        // POST: Racoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Racoes == null)
            {
                return Problem("Entity set 'Contexto.Racoes'  is null.");
            }
            var Racoes = await _context.Racoes.FindAsync(id);
            if (Racoes != null)
            {
                _context.Racoes.Remove(Racoes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RacoesExists(int id)
        {
          return _context.Racoes.Any(e => e.id == id);
        }
    }
}
