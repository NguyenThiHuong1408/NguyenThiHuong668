using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThiHuong668.Data;
using NguyenThiHuong668.Models;

namespace NguyenThiHuong668.Controllers
{
    public class NTH0668Controller : Controller
    {
        private readonly NguyenThiHuong668Context _context;

        public NTH0668Controller(NguyenThiHuong668Context context)
        {
            _context = context;
        }

        // GET: NTH0668
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTH0668.ToListAsync());
        }

        // GET: NTH0668/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTH0668 = await _context.NTH0668
                .FirstOrDefaultAsync(m => m.NTHId == id);
            if (nTH0668 == null)
            {
                return NotFound();
            }

            return View(nTH0668);
        }

        // GET: NTH0668/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTH0668/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTHId,NTHName,NTHGende")] NTH0668 nTH0668)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTH0668);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTH0668);
        }

        // GET: NTH0668/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTH0668 = await _context.NTH0668.FindAsync(id);
            if (nTH0668 == null)
            {
                return NotFound();
            }
            return View(nTH0668);
        }

        // POST: NTH0668/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTHId,NTHName,NTHGende")] NTH0668 nTH0668)
        {
            if (id != nTH0668.NTHId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTH0668);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTH0668Exists(nTH0668.NTHId))
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
            return View(nTH0668);
        }

        // GET: NTH0668/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTH0668 = await _context.NTH0668
                .FirstOrDefaultAsync(m => m.NTHId == id);
            if (nTH0668 == null)
            {
                return NotFound();
            }

            return View(nTH0668);
        }

        // POST: NTH0668/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nTH0668 = await _context.NTH0668.FindAsync(id);
            _context.NTH0668.Remove(nTH0668);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTH0668Exists(string id)
        {
            return _context.NTH0668.Any(e => e.NTHId == id);
        }
    }
}
