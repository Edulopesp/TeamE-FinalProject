using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamE_Project.Areas.Identity.Data;
using TeamE_Project.Models;

namespace TeamE_Project.Controllers
{
    public class RegimesController : Controller
    {
        private readonly DataContext _context;

        public RegimesController(DataContext context)
        {
            _context = context;
        }

        // GET: Regimes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Regime.ToListAsync());
        }

        // GET: Regimes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regime = await _context.Regime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (regime == null)
            {
                return NotFound();
            }

            return View(regime);
        }

        // GET: Regimes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Regimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Regime regime)
        {
            if (ModelState.IsValid)
            {
                _context.Add(regime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(regime);
        }

        // GET: Regimes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regime = await _context.Regime.FindAsync(id);
            if (regime == null)
            {
                return NotFound();
            }
            return View(regime);
        }

        // POST: Regimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Regime regime)
        {
            if (id != regime.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(regime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegimeExists(regime.Id))
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
            return View(regime);
        }

        // GET: Regimes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regime = await _context.Regime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (regime == null)
            {
                return NotFound();
            }

            return View(regime);
        }

        // POST: Regimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var regime = await _context.Regime.FindAsync(id);
            if (regime != null)
            {
                _context.Regime.Remove(regime);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegimeExists(int id)
        {
            return _context.Regime.Any(e => e.Id == id);
        }
    }
}
