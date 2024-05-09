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
    public class ResponsavelsController : Controller
    {
        private readonly DataContext _context;

        public ResponsavelsController(DataContext context)
        {
            _context = context;
        }

        // GET: Responsavels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Responsavel.ToListAsync());
        }

        // GET: Responsavels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavel = await _context.Responsavel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (responsavel == null)
            {
                return NotFound();
            }

            return View(responsavel);
        }

        // GET: Responsavels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Responsavels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Responsavel responsavel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(responsavel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(responsavel);
        }

        // GET: Responsavels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavel = await _context.Responsavel.FindAsync(id);
            if (responsavel == null)
            {
                return NotFound();
            }
            return View(responsavel);
        }

        // POST: Responsavels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Responsavel responsavel)
        {
            if (id != responsavel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(responsavel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResponsavelExists(responsavel.Id))
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
            return View(responsavel);
        }

        // GET: Responsavels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavel = await _context.Responsavel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (responsavel == null)
            {
                return NotFound();
            }

            return View(responsavel);
        }

        // POST: Responsavels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var responsavel = await _context.Responsavel.FindAsync(id);
            if (responsavel != null)
            {
                _context.Responsavel.Remove(responsavel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResponsavelExists(int id)
        {
            return _context.Responsavel.Any(e => e.Id == id);
        }
    }
}
