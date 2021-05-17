using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using datacore;
using layedata;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bomblearn.Controllers
{
    public class soalshoma : Controller
    {
        Isoalinter isoalinter;
        Idoreinter Idoreinter;
        public soalshoma(Isoalinter isoalintera, Idoreinter idoreinter)
        {
            isoalinter = isoalintera;
            Idoreinter = idoreinter;
        }
        #region indexindex
        [Route("soal")]
        public IActionResult Index()
        {
            ViewData["Title"] = "سوالات کاربران";
            ViewData["descripthin"] = "این قسمت سایت به افرادی که سوالاتی درباره دوره ها داشتند تعلق گرفته است";
            ViewData["addrescan"] = "soal";
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            return View(isoalinter.getallsoal());
        }
        #endregion

        [Route("soal/{id}")]
        public IActionResult Indexa(string id)
        {
            try
            {
                var a = isoalinter.getsoalbyiddore(Convert.ToInt32(id));
                var b = Idoreinter.getdorebyid(Convert.ToInt32(id));
                if (b == null)
                {
                    return Redirect("/404page");
                }
                ViewData["Title"] = b.dorename + " سوالات ";
                ViewData["descripthin"] = b.shortmatn;
                ViewData["addrescan"] = "soal/" + id;
                ViewData["ogimage"] = b.doreimageurl;
                ViewBag.namedore = b.dorename;
                ViewBag.iddore = id;
                return View(a);
            }
            catch
            {
                return Redirect("/404page");
            }
        }

        [Route("soalsearch")]
        public IActionResult Indexaa(string searchinput)
        {
            ViewData["Title"] = searchinput;
            return View("index",isoalinter.getsoalbynamesoal(searchinput));
        }

        #region cretesoal
        [Route("soal/create/{id}")]
        public IActionResult create(string id)
        {
            ViewData["Title"] = "ثبت سوال جدید";
            ViewData["descripthin"] = " این قسمت سایت به افرادی که سوالاتی درباره دوره ها داشتند تعلق گرفته است که سوالاشان را مطرح کنند";
            ViewData["addrescan"] = "soal/create";
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            ViewBag.iddore = Convert.ToInt32(id);
            return View();
        }
        #endregion

        #region postcrete
        [Route("soal/create")]
        [HttpPost]
        public IActionResult createa(soal soal, IFormFile imageup)
        {
            if (ModelState.IsValid)
            {
                soal.userid = isoalinter.getidbynameuser(User.Identity.Name);
                soal.soalid = 3;
                if (imageup == null)
                {
                    if (isoalinter.addsoal(soal))
                    {
                        return Redirect("/question/" + soal.soalid);
                    }
                    else
                    {
                        ModelState.AddModelError("imageup", "مشکلی برای ارسال سوال به وجود آمد");
                        ViewData["Title"] = "ثبت سوال جدید";
                        ViewData["descripthin"] = " این قسمت سایت به افرادی که سوالاتی درباره دوره ها داشتند تعلق گرفته است که سوالاشان را مطرح کنند";
                        ViewData["addrescan"] = "soal/create";
                        ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
                        ViewBag.iddore = soal.doreid;
                        return View("create", soal);
                    }

                }
                string filename = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/img", Guid.NewGuid().ToString() + imageup.FileName);
                using (var stream = System.IO.File.Create(filename))
                {
                    imageup.CopyTo(stream);
                }
                System.IO.FileInfo a = new System.IO.FileInfo(filename);//a
                if (a.Length > 2000000)//b
                {
                    ModelState.AddModelError("imageup", "فایل مورد نظر بیشتر از دو مگابایت است");
                    System.IO.File.Delete(filename);
                    ViewData["Title"] = "ثبت سوال جدید";
                    ViewData["descripthin"] = " این قسمت سایت به افرادی که سوالاتی درباره دوره ها داشتند تعلق گرفته است که سوالاشان را مطرح کنند";
                    ViewData["addrescan"] = "soal/create";
                    ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
                    ViewBag.iddore = soal.doreid;
                    return View("create", soal);
                }
                if (Idoreinter.postftp(filename, imageup.FileName))
                {

                }
                else
                {
                    ModelState.AddModelError("imageup", "مشکلی برای ارسال سوال به وجود آمد");
                    System.IO.File.Delete(filename);
                    ViewData["Title"] = "ثبت سوال جدید";
                    ViewData["descripthin"] = " این قسمت سایت به افرادی که سوالاتی درباره دوره ها داشتند تعلق گرفته است که سوالاشان را مطرح کنند";
                    ViewData["addrescan"] = "soal/create";
                    ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
                    ViewBag.iddore = soal.doreid;
                    return View("create", soal);
                }
                soal.zamimesoal = "https://sdna.goldamooz.com/" + imageup.FileName;
                if (isoalinter.addsoal(soal))
                {
                    System.IO.File.Delete(filename);
                    return Redirect("/question/" + soal.soalid);
                }
                else
                {
                    ModelState.AddModelError("imageup", "مشکلی برای ارسال سوال به وجود آمد");
                    System.IO.File.Delete(filename);
                    ViewData["Title"] = "ثبت سوال جدید";
                    ViewData["descripthin"] = " این قسمت سایت به افرادی که سوالاتی درباره دوره ها داشتند تعلق گرفته است که سوالاشان را مطرح کنند";
                    ViewData["addrescan"] = "soal/create";
                    ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
                    ViewBag.iddore = soal.doreid;
                    return View("create", soal);
                }

            }
            ViewData["Title"] = "ثبت سوال جدید";
            ViewData["descripthin"] = " این قسمت سایت به افرادی که سوالاتی درباره دوره ها داشتند تعلق گرفته است که سوالاشان را مطرح کنند";
            ViewData["addrescan"] = "soal/create";
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            ViewBag.iddore = soal.doreid;
            return View("create", soal);
        }
        #endregion

        #region khodesoal
        [Route("question/{id}")]
        public IActionResult khodesoal(string id)
        {
            var a = isoalinter.getsoalbyid(Convert.ToInt32(id));
            if (a == null)
            {
                return Redirect("/404page");
            }
            ViewData["Title"] = a.soaltitr;
            ViewData["descripthin"] = a.soalmatn;
            ViewData["addrescan"] = "question/" + id;
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            return View(a);
        }
        #endregion

        #region javabsahih
        [fiterkardankarbaran(2)]
        [Route("javabsahihbood")]
        public IActionResult javabsahihbood(string idsoal,string idjavab) 
        {
            try
            {
                isoalinter.javabsahihkon(User.Identity.Name,Convert.ToInt32(idjavab));
                return Redirect("/question/" + idsoal);
            }
            catch
            {
                return Redirect("/question/"+idsoal);
            }
        }
        #endregion


        #region javab
        [fiterkardankarbaran(2)]
        [Route("soal/javabcreate")]
        [HttpPost]
        public IActionResult javabcreate(javab javab, IFormFile imageup)
        {
            if (ModelState.IsValid)
            {
                int abccb = isoalinter.getidbynameuser(User.Identity.Name);
                javab.javabdahande = User.Identity.Name;
                javab.userid = abccb;
                javab.modarsgofte = isoalinter.modarsgsaya(abccb);
                if (imageup == null)
                {
                    if (isoalinter.addjavab(javab))
                    {
                        return Redirect("/question/" + javab.soalid);
                    }
                    else
                    {
                        ModelState.AddModelError("imageup", "مشکلی برای ارسال جواب به وجود آمد");
                        return Redirect("/question/" + javab.soalid);
                    }

                }
                string filename = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/img", Guid.NewGuid().ToString() + imageup.FileName);
                using (var stream = System.IO.File.Create(filename))
                {
                    imageup.CopyTo(stream);
                }
                System.IO.FileInfo a = new System.IO.FileInfo(filename);//a
                if (a.Length > 2000000)//b
                {
                    ModelState.AddModelError("imageup", "فایل مورد نظر بیشتر از دو مگابایت است");
                    System.IO.File.Delete(filename);
                    ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
                    return Redirect("/question/" + javab.soalid);
                }
                if (Idoreinter.postftp(filename, imageup.FileName))
                {

                }
                else
                {
                    ModelState.AddModelError("imageup", "مشکلی برای ارسال جواب به وجود آمد");
                    System.IO.File.Delete(filename);
                    return Redirect("/question/" + javab.soalid);
                }
                javab.zamimejavab = "https://sdna.goldamooz.com/" + imageup.FileName;
                if (isoalinter.addjavab(javab))
                {
                    System.IO.File.Delete(filename);
                    return Redirect("/question/" + javab.soalid);
                }
                else
                {
                    ModelState.AddModelError("imageup", "مشکلی برای ارسال جواب به وجود آمد");
                    System.IO.File.Delete(filename);
                    return Redirect("/question/" + javab.soalid);
                }

            }
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            return Redirect("/question/" + javab.soalid);
        }
        #endregion
    }
}
