using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using layedata;
using datacore;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net;

namespace bomblearn.Controllers
{
    public class doresController : Controller
    {
        private Idoreinter Idoreinter;

        public doresController(Idoreinter idoreintera)
        {
            Idoreinter = idoreintera;
        }

        // GET: dores1
        [Route("doreadmin/{id}")]
        public async Task<IActionResult> Index(string id)
        {
            var a = Idoreinter.getalldorebymodarsname(id);
            if (a!=null)
            {
                ViewBag.vogodasht = true;
                return View(a);
            }
            else
            {
                ViewBag.vogodasht = false;
                return View(a);
            }
        }

        // GET: dores1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dore = Idoreinter.getdorebyid(id.Value);
            if (dore == null)
            {
                return NotFound();
            }

            return View(dore);
        }

        // GET: dores1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: dores1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("doreid,shortmatn,dorename,doremodars,dorehgaymat,dorebargozary,doretedadgalase,doretedaddaneshamooz,doretedadsaatbargozary,doresath,doreimageurl,dorematn")] dore dore, IFormFile imageup)
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
                        if (Idoreinter.postftp(filename,imageup.FileName))
                        {

                        }
                        else
                        {
                            return View(dore);
                        }
                        dore.doreimageurl = "https://sdna.goldamooz.com/" + imageup.FileName;
                        System.IO.File.Delete(filename);
                        dore.doretedadgalase = 0;
                        dore.doretedaddaneshamooz = 0;
                        dore.doretedadsaatbargozary = "10:0:1";
                        PersianCalendar pc = new PersianCalendar();
                        dore.doreakharinberoozresany = pc.GetYear(DateTime.Now).ToString() + "/index" + pc.GetMonth(DateTime.Now).ToString() + "/index" + pc.GetDayOfMonth(DateTime.Now).ToString();
                        Idoreinter.adddore(dore);
                        return Redirect("/doreadmin/" + User.Identity.Name);
                    }
                }
                catch
                {
                    return View(dore);
                }
            }
            return View(dore);
        }

        // GET: dores1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dore = Idoreinter.getdorebyid(id.Value);
            if (dore == null)
            {
                return NotFound();
            }
            return View(dore);
        }

        // POST: dores1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("doreid,shortmatn,dorename,doremodars,dorehgaymat,dorebargozary,doretedadgalase,doretedaddaneshamooz,doretedadsaatbargozary,doresath,doreakharinberoozresany,doreimageurl,dorematn")] dore dore)
        {
            if (id != dore.doreid)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {

                if (Idoreinter.updatedore(dore))
                {

                }
                else
                {
                    if (!Idoreinter.doreExists(dore.doreid))
                    {
                        return NotFound();
                    }
                    else
                    {

                    }
                }
                return Redirect("/doreadmin/" + User.Identity.Name);
            }
            return View(dore);
        }

        // GET: dores1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dore = Idoreinter.getdorebyid(id.Value);
            if (dore == null)
            {
                return NotFound();
            }

            return View(dore);
        }

        // POST: dores1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dore = Idoreinter.deletdorebyid(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
