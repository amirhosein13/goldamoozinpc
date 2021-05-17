using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using layedata;
using datacore;

namespace bomblearn.Controllers
{
    [fiterkardankarbaran(5)]
    public class userbombsController : Controller
    {
        private readonly context _context;

        public userbombsController(context context)
        {
            _context = context;
        }

        // GET: userbombs
        public async Task<IActionResult> Index()
        {
            var context = _context.userbombs.Include(u => u.role);
            return View(await context.ToListAsync());
        }

        // GET: userbombs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userbomb = await _context.userbombs
                .Include(u => u.role)
                .FirstOrDefaultAsync(m => m.userid == id);
            if (userbomb == null)
            {
                return NotFound();
            }

            return View(userbomb);
        }

        // GET: userbombs/Create
        public IActionResult Create()
        {
            ViewData["roleid"] = new SelectList(_context.roles, "roleid", "rolename");
            return View();
        }

        // POST: userbombs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("userid,username,userpassword,useremail,useractivatecode,useractiveaya,roleid")] userbomb userbomb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userbomb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["roleid"] = new SelectList(_context.roles, "roleid", "rolename", userbomb.roleid);
            return View(userbomb);
        }

        // GET: userbombs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userbomb = await _context.userbombs.FindAsync(id);
            if (userbomb == null)
            {
                return NotFound();
            }
            ViewData["roleid"] = new SelectList(_context.roles, "roleid", "rolename", userbomb.roleid);
            return View(userbomb);
        }

        // POST: userbombs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("userid,username,userpassword,useremail,useractivatecode,useractiveaya,roleid")] userbomb userbomb)
        {
            if (id != userbomb.userid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userbomb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!userbombExists(userbomb.userid))
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
            ViewData["roleid"] = new SelectList(_context.roles, "roleid", "rolename", userbomb.roleid);
            return View(userbomb);
        }

        // GET: userbombs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userbomb = await _context.userbombs
                .Include(u => u.role)
                .FirstOrDefaultAsync(m => m.userid == id);
            if (userbomb == null)
            {
                return NotFound();
            }

            return View(userbomb);
        }

        // POST: userbombs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userbomb = await _context.userbombs.FindAsync(id);
            _context.userbombs.Remove(userbomb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool userbombExists(int id)
        {
            return _context.userbombs.Any(e => e.userid == id);
        }
    }
}
