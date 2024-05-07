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
    public class NomesController : Controller
    {
        private readonly DataContext _context;

        public NomesController(DataContext context)
        {
            _context = context;
        }

        // GET: Nomes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nome.ToListAsync());
        }

        // GET: Nomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nome = await _context.Nome
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nome == null)
            {
                return NotFound();
            }

            return View(nome);
        }

        // GET: Nomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Nome nome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nome);
        }

        // GET: Nomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nome = await _context.Nome.FindAsync(id);
            if (nome == null)
            {
                return NotFound();
            }
            return View(nome);
        }

        // POST: Nomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Nome nome)
        {
            if (id != nome.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NomeExists(nome.Id))
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
            return View(nome);
        }

        // GET: Nomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nome = await _context.Nome
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nome == null)
            {
                return NotFound();
            }

            return View(nome);
        }

        // POST: Nomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nome = await _context.Nome.FindAsync(id);
            if (nome != null)
            {
                _context.Nome.Remove(nome);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NomeExists(int id)
        {
            return _context.Nome.Any(e => e.Id == id);
        }
    }
}
