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
    public class PersonNTH668Controller : Controller
    {
        private readonly NguyenThiHuong668Context _context;

        public PersonNTH668Controller(NguyenThiHuong668Context context)
        {
            _context = context;
        }

        // GET: PersonNTH668
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNTH668.ToListAsync());
        }

        // GET: PersonNTH668/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTH668 = await _context.PersonNTH668
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTH668 == null)
            {
                return NotFound();
            }

            return View(personNTH668);
        }

        // GET: PersonNTH668/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNTH668/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNTH668 personNTH668)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNTH668);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNTH668);
        }

        // GET: PersonNTH668/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTH668 = await _context.PersonNTH668.FindAsync(id);
            if (personNTH668 == null)
            {
                return NotFound();
            }
            return View(personNTH668);
        }

        // POST: PersonNTH668/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonNTH668 personNTH668)
        {
            if (id != personNTH668.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNTH668);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNTH668Exists(personNTH668.PersonId))
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
            return View(personNTH668);
        }

        // GET: PersonNTH668/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTH668 = await _context.PersonNTH668
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTH668 == null)
            {
                return NotFound();
            }

            return View(personNTH668);
        }

        // POST: PersonNTH668/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNTH668 = await _context.PersonNTH668.FindAsync(id);
            _context.PersonNTH668.Remove(personNTH668);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNTH668Exists(string id)
        {
            return _context.PersonNTH668.Any(e => e.PersonId == id);
        }
    }
}
