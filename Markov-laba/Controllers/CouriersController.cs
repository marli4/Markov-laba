using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Markov_laba.Data;
using Markov_laba.Models;

namespace Markov_laba.Controllers
{
    public class CouriersController : Controller
    {
        private readonly Markov_labaContext _context;

        public CouriersController(Markov_labaContext context)
        {
            _context = context;
        }

        // GET: Couriers
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Courier == null)
            {
                return Problem("Entity is null.");
            }

            var couriers = from m in _context.Courier
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                couriers = couriers.Where(s => s.login!.ToUpper().Contains(searchString.ToUpper()));
            }
            return View(await couriers.ToListAsync());
        }

        // GET: Couriers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courier = await _context.Courier
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courier == null)
            {
                return NotFound();
            }

            return View(courier);
        }

        // GET: Couriers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Couriers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,login")] Courier courier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courier);
        }

        // GET: Couriers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courier = await _context.Courier.FindAsync(id);
            if (courier == null)
            {
                return NotFound();
            }
            return View(courier);
        }

        // POST: Couriers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,login")] Courier courier)
        {
            if (id != courier.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourierExists(courier.Id))
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
            return View(courier);
        }

        // GET: Couriers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courier = await _context.Courier
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courier == null)
            {
                return NotFound();
            }

            return View(courier);
        }

        // POST: Couriers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courier = await _context.Courier.FindAsync(id);
            if (courier != null)
            {
                _context.Courier.Remove(courier);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourierExists(int id)
        {
            return _context.Courier.Any(e => e.Id == id);
        }
    }
}
