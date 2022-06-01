using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eletric_app.Models;

namespace eletric_app.Controllers
{
    public class VeiculoCsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VeiculoCsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VeiculoCs
        public async Task<IActionResult> Index()
        {
            return View(await _context.VeiculosC.ToListAsync());
        }

        // GET: VeiculoCs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoC = await _context.VeiculosC
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoC == null)
            {
                return NotFound();
            }

            return View(veiculoC);
        }

        // GET: VeiculoCs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VeiculoCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Modelo,Motor,Media,Valor,Data")] VeiculoC veiculoC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veiculoC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculoC);
        }

        // GET: VeiculoCs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoC = await _context.VeiculosC.FindAsync(id);
            if (veiculoC == null)
            {
                return NotFound();
            }
            return View(veiculoC);
        }

        // POST: VeiculoCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Modelo,Motor,Media,Valor,Data")] VeiculoC veiculoC)
        {
            if (id != veiculoC.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veiculoC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeiculoCExists(veiculoC.Id))
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
            return View(veiculoC);
        }

        // GET: VeiculoCs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoC = await _context.VeiculosC
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoC == null)
            {
                return NotFound();
            }

            return View(veiculoC);
        }

        // POST: VeiculoCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veiculoC = await _context.VeiculosC.FindAsync(id);
            _context.VeiculosC.Remove(veiculoC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeiculoCExists(int id)
        {
            return _context.VeiculosC.Any(e => e.Id == id);
        }
    }
}
