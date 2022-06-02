using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eletric_app.Models;
using Microsoft.AspNetCore.Authorization;

namespace eletric_app.Controllers
{
    [Authorize]
    public class VeiculoEleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VeiculoEleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VeiculoEle
        public async Task<IActionResult> Index()
        {
            return View(await _context.VeiculosE.ToListAsync());
        }

        // GET: VeiculoEle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoE = await _context.VeiculosE
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoE == null)
            {
                return NotFound();
            }

            return View(veiculoE);
        }

        // GET: VeiculoEle/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VeiculoEle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Modelo,Motor,Capacidade,Valor,Data,Autonomia,Eficiencia")] VeiculoE veiculoE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veiculoE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculoE);
        }

        // GET: VeiculoEle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoE = await _context.VeiculosE.FindAsync(id);
            if (veiculoE == null)
            {
                return NotFound();
            }
            return View(veiculoE);
        }

        // POST: VeiculoEle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Modelo,Motor,Capacidade,Valor,Data,Autonomia,Eficiencia")] VeiculoE veiculoE)
        {
            if (id != veiculoE.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veiculoE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeiculoEleExists(veiculoE.Id))
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
            return View(veiculoE);
        }

        // GET: VeiculoEle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoE = await _context.VeiculosE
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoE == null)
            {
                return NotFound();
            }

            return View(veiculoE);
        }

        // POST: VeiculoEle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veiculoE = await _context.VeiculosE.FindAsync(id);
            _context.VeiculosE.Remove(veiculoE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeiculoEleExists(int id)
        {
            return _context.VeiculosE.Any(e => e.Id == id);
        }
    }
}
