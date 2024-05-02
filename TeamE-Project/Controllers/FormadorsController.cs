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
    public class FormadorsController : Controller
    {
        private readonly DataContext _context;

        public FormadorsController(DataContext context)
        {
            _context = context;
        }

        // GET: Formadors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formador.ToListAsync());
        }

        // GET: Formadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formador = await _context.Formador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formador == null)
            {
                return NotFound();
            }

            return View(formador);
        }

        // GET: Formadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Formador formador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formador);
        }

        // GET: Formadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formador = await _context.Formador.FindAsync(id);
            if (formador == null)
            {
                return NotFound();
            }
            return View(formador);
        }

        // POST: Formadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Formador formador)
        {
            if (id != formador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormadorExists(formador.Id))
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
            return View(formador);
        }

        // GET: Formadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formador = await _context.Formador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formador == null)
            {
                return NotFound();
            }

            return View(formador);
        }

        // POST: Formadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formador = await _context.Formador.FindAsync(id);
            if (formador != null)
            {
                _context.Formador.Remove(formador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormadorExists(int id)
        {
            return _context.Formador.Any(e => e.Id == id);
        }
    }
}
