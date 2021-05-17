using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using layedata;

namespace bomblearn.Controllers
{
    public class soalsController : Controller
    {
        private readonly context _context;

        public soalsController(context context)
        {
            _context = context;
        }

        // GET: soals
        public async Task<IActionResult> Index()
        {
            var context = _context.Soals.Include(s => s.Dore);
            return View(await context.ToListAsync());
        }

        // GET: soals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soal = await _context.Soals
                .Include(s => s.Dore)
                .FirstOrDefaultAsync(m => m.soalid == id);
            if (soal == null)
            {
                return NotFound();
            }

            return View(soal);
        }

        // GET: soals/Create
        public IActionResult Create()
        {
            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorematn");
            return View();
        }

        // POST: soals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("soalid,soaltitr,soalmatn,zamimesoal,doreid")] soal soal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(soal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorematn", soal.doreid);
            return View(soal);
        }

        // GET: soals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soal = await _context.Soals.FindAsync(id);
            if (soal == null)
            {
                return NotFound();
            }
            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorematn", soal.doreid);
            return View(soal);
        }

        // POST: soals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("soalid,soaltitr,soalmatn,zamimesoal,doreid")] soal soal)
        {
            if (id != soal.soalid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(soal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!soalExists(soal.soalid))
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
            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorematn", soal.doreid);
            return View(soal);
        }

        // GET: soals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soal = await _context.Soals
                .Include(s => s.Dore)
                .FirstOrDefaultAsync(m => m.soalid == id);
            if (soal == null)
            {
                return NotFound();
            }

            return View(soal);
        }

        // POST: soals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var soal = await _context.Soals.FindAsync(id);
            _context.Soals.Remove(soal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool soalExists(int id)
        {
            return _context.Soals.Any(e => e.soalid == id);
        }
    }
}
