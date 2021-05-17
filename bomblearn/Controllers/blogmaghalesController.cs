using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using layedata;
using datacore;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace bomblearn.Controllers
{
    [fiterkardankarbaran(4)]
    public class blogmaghalesController : Controller
    {
        private readonly context _context;
        private Idoreinter Idoreinter;
        public blogmaghalesController(context context, Idoreinter idoreintera)
        {
            _context = context;
            Idoreinter = idoreintera;
        }

        // GET: blogmaghales
        [Route("blogadmin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.blogmaghales.ToListAsync());
        }

        // GET: blogmaghales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogmaghale = await _context.blogmaghales
                .FirstOrDefaultAsync(m => m.blogmaghaleid == id);
            if (blogmaghale == null)
            {
                return NotFound();
            }

            return View(blogmaghale);
        }

        // GET: blogmaghales/Create
        public IActionResult Create()
        {
            ViewBag.modarsid = _context.userbombs.Where(a => a.username == User.Identity.Name).FirstOrDefault().userid;
            ViewBag.modaresname =User.Identity.Name;
            return View();
        }

        // POST: blogmaghales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("blogmaghaleid,titr,matnkootahblog,matnkamelblog,userid")] blogmaghale blogmaghale, IFormFile imageup)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (imageup != null)
                    {
                        string filename = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/img", imageup.FileName);
                        using (var stream = System.IO.File.Create(filename))
                        {
                            imageup.CopyTo(stream);
                        }
                        if (Idoreinter.postftp(filename, imageup.FileName))
                        {

                        }
                        else
                        {
                            return View(blogmaghale);
                        }
                        blogmaghale.urlimage = "https://sdna.goldamooz.com/" + imageup.FileName;
                        System.IO.File.Delete(filename);
                        _context.Add(blogmaghale);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch
                {
                    return View(blogmaghale);
                }
            }
            return View(blogmaghale);
        }

        // GET: blogmaghales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogmaghale = await _context.blogmaghales.FindAsync(id);
            if (blogmaghale == null)
            {
                return NotFound();
            }
            return View(blogmaghale);
        }

        // POST: blogmaghales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("blogmaghaleid,titr,matnkootahblog,matnkamelblog,userid")] blogmaghale blogmaghale)
        {
            if (id != blogmaghale.blogmaghaleid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blogmaghale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!blogmaghaleExists(blogmaghale.blogmaghaleid))
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
            return View(blogmaghale);
        }

        // GET: blogmaghales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogmaghale = await _context.blogmaghales
                .FirstOrDefaultAsync(m => m.blogmaghaleid == id);
            if (blogmaghale == null)
            {
                return NotFound();
            }

            return View(blogmaghale);
        }

        // POST: blogmaghales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogmaghale = await _context.blogmaghales.FindAsync(id);
            _context.blogmaghales.Remove(blogmaghale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool blogmaghaleExists(int id)
        {
            return _context.blogmaghales.Any(e => e.blogmaghaleid == id);
        }
    }
}
