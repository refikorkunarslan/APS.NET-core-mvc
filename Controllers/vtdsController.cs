using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGK.Data;
using SGK.Models;

namespace SGK.Controllers
{
    public class vtdsController : Controller
    {
        private readonly SGKContext _context;

        public vtdsController(SGKContext context)
        {
            _context = context;
        }

        // GET: vtds
        public async Task<IActionResult> Index(string searchString)
        {
            var v = from m in _context.vtd
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                v = v.Where(s => s.TC.Contains(searchString));
            }

            return View(await v.ToListAsync());
        }

        // GET: vtds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vtd = await _context.vtd
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vtd == null)
            {
                return NotFound();
            }

            return View(vtd);
        }

        // GET: vtds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: vtds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,surname,TC,phone")] vtd vtd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vtd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vtd);
        }

        // GET: vtds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vtd = await _context.vtd.FindAsync(id);
            if (vtd == null)
            {
                return NotFound();
            }
            return View(vtd);
        }

        // POST: vtds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,surname,TC,phone")] vtd vtd)
        {
            if (id != vtd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vtd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!vtdExists(vtd.Id))
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
            return View(vtd);
        }

        // GET: vtds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vtd = await _context.vtd
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vtd == null)
            {
                return NotFound();
            }

            return View(vtd);
        }

        // POST: vtds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vtd = await _context.vtd.FindAsync(id);
            _context.vtd.Remove(vtd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool vtdExists(int id)
        {
            return _context.vtd.Any(e => e.Id == id);
        }
    }
}
