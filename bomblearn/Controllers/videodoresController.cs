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
using System.Globalization;

namespace bomblearn.Controllers
{
    public class videodoresController : Controller
    {
        private readonly context _context;
        private IVideo videoa;
        private Idoreinter idoreintea;
        public videodoresController(context context, IVideo video, Idoreinter idoreinter)
        {
            _context = context;
            videoa = video;
            idoreintea = idoreinter;
        }

        // GET: videodores
        [Route("videodore/{id}")]
        public async Task<IActionResult> Index(string id)
        {
            var dore = idoreintea.getdorebyid(Convert.ToInt32(id));
            if (dore != null)
            {
                ViewBag.dorename = dore.dorename;
                ViewBag.doremodars = dore.doremodars;
            }
            else
            {
                ViewBag.dorename = "همچین دوره ای پیدا نشد";
                ViewBag.doremodars = "همچین مدرسی برای دوره پیدا نشد";
            }
            return View(videoa.getallvideobyid(Convert.ToInt32(id)));
        }

        // GET: videodores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videodore = videoa.getvideobyid(id.Value);
            if (videodore == null)
            {
                return NotFound();
            }

            return View(videodore);
        }

        // GET: videodores/Create
        public IActionResult Create()
        {
            ViewData["doreid"] = new SelectList(_context.dores.Where(u => u.doremodars == User.Identity.Name), "doreid", "dorename");
            return View();
        }

        // POST: videodores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("videoid,videomatn,videoname,urlvideo,doreid")] videodore videodore, IFormFile imageup)
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
                        if (idoreintea.postftp(filename, imageup.FileName))
                        {

                        }
                        else
                        {
                            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorename", videodore.doreid);
                           return View(videodore);
                        }
                        videodore.urlvideo = "https://sdna.goldamooz.com/" + imageup.FileName;
                        System.IO.File.Delete(filename);
                        videoa.addvideo(videodore);
                        var a = idoreintea.getdorebyid(videodore.doreid);
                        a.doretedadgalase += 1;
                        PersianCalendar pc = new PersianCalendar();
                        a.doreakharinberoozresany = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
                        idoreintea.updatedore(a);
                        return Redirect("/videodore/"+videodore.doreid);
                    }
                    else
                    {
                        ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorename", videodore.doreid);
                        return View(videodore);
                    }
                }
                catch
                {
                    ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorename", videodore.doreid);
                    return View(videodore);
                }

            }
            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorename", videodore.doreid);
            return View(videodore);
        }

        // GET: videodores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videodore = videoa.getvideobyid(id.Value);
            if (videodore == null)
            {
                return NotFound();
            }
            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorename", videodore.doreid);
            return View(videodore);
        }

        // POST: videodores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("videoid,videoname,urlvideo,doreid")] videodore videodore)
        {
            if (id != videodore.videoid)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var a = idoreintea.getdorebyid(videodore.doreid);
                    PersianCalendar pc = new PersianCalendar();
                    a.doreakharinberoozresany = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
                    idoreintea.updatedore(a);
                    videoa.uodatevideo(videodore);                  
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!videoa.videodoreExists(videodore.videoid))
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
            ViewData["doreid"] = new SelectList(_context.dores, "doreid", "dorename", videodore.doreid);
            return View(videodore);
        }

        // GET: videodores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videodore = videoa.getvideobyid(id.Value);
            if (videodore == null)
            {
                return NotFound();
            }

            return View(videodore);
        }

        // POST: videodores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            videoa.deletebyid(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
