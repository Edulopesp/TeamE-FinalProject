
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
    public class CalendariosController : Controller
    {
        private readonly DataContext _context;

        public CalendariosController(DataContext context)
        {
            _context = context;
        }

        // GET: Calendarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Calendario.ToListAsync());
        }

        // GET: Calendarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendario = await _context.Calendario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendario == null)
            {
                return NotFound();
            }

            return View(calendario);
        }

        // GET: Calendarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calendarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Calendario calendario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calendario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calendario);
        }

        // GET: Calendarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendario = await _context.Calendario.FindAsync(id);
            if (calendario == null)
            {
                return NotFound();
            }
            return View(calendario);
        }

        // POST: Calendarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Calendario calendario)
        {
            if (id != calendario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarioExists(calendario.Id))
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
            return View(calendario);
        }

        // GET: Calendarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendario = await _context.Calendario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendario == null)
            {
                return NotFound();
            }

            return View(calendario);
        }

        // POST: Calendarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calendario = await _context.Calendario.FindAsync(id);
            if (calendario != null)
            {
                _context.Calendario.Remove(calendario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalendarioExists(int id)
        {
            return _context.Calendario.Any(e => e.Id == id);
        }
    }
}
