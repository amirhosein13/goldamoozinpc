using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using layedata;
using datacore;
using Microsoft.AspNetCore.Mvc;
using Zarinpal;
using Microsoft.AspNetCore.Http;

namespace bomblearn.Controllers
{
    public class Homedore : Controller
    {
        Idoreinter idore;
        IVideo Videoa;
        IPaydore paydorea;
        public Homedore(Idoreinter dorsd, IVideo video, IPaydore paydore)
        {
            paydorea = paydore;
            idore = dorsd;
            Videoa = video;
        }
        [Route("dore/{id}")]
        public IActionResult dore(string id, int? tr)
        {
            doreindexpage doreindexpage = new doreindexpage();
            doreindexpage = idore.getdorekamelbyid(Convert.ToInt32(id));
            ViewBag.kharid = tr;
            ViewBag.isteacher = false;
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.dastres = paydorea.getkhariddore(User.Identity.Name, Convert.ToInt32(id));
                ViewBag.isteacher = idore.isteacher(User.Identity.Name);
            }
            ViewData["Title"] = doreindexpage.dorea.dorename;
            ViewData["descripthin"] = doreindexpage.dorea.shortmatn;
            ViewData["addrescan"] = "dore/" + id;
            ViewData["ogimage"] = doreindexpage.dorea.doreimageurl;
            return View(doreindexpage);
        }
        #region peyment




        [Route("payment/{id}")]
        public IActionResult paymentpost(int id)
        {
            int a = paydorea.returniduserbyname(User.Identity.Name);
            int b = paydorea.adduserpay(a, id);
            if (b != 0)
            {
                var payment = new Zarinpal.Payment("0396feaf-6e11-4ff7-a1a5-8855b95ad08e", paydorea.getghaymatdore(id));

                var res = payment.PaymentRequest("خرید دوره از گلد آموز", "https://goldamooz.com/payget/" + b);

                if (res.Result.Status == 100)
                {
                    return Redirect("https://zarinpal.com/pg/StartPay/" + res.Result.Authority);
                }
                else
                {
                    return Redirect("/dore/" + id + "?tr=1");
                }
            }
            else
            {
                return Redirect("/dore/" + id + "?tr=1");
            }

        }
        [Route("payget/{id}")]
        public IActionResult payget(int id)
        {
            if (HttpContext.Request.Query["Status"] != "" &&
               HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
               && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var userdorepay = paydorea.returniduserdorepay(id);

                var payment = new Zarinpal.Payment("0396feaf-6e11-4ff7-a1a5-8855b95ad08e", userdorepay.ghaymat);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    paydorea.updatepardakht(id);
                    ViewBag.kharid = 2;
                    return Redirect("/dore/" + paydorea.returniduserdorepay(id).doreid + "?tr=2");
                }
                else
                {
                    ViewBag.kharid = 1;
                    return Redirect("/dore/" + paydorea.returniduserdorepay(id).doreid + "?tr=1");
                }
            }
            ViewBag.kharid = 1;
            return Redirect("/dore/" + paydorea.returniduserdorepay(id).doreid + "?tr=1");
        }
        #endregion

        [Route("alldore")]
        public IActionResult alldore()
        {
            ViewData["Title"] = "آخرین دوره های گلد آموز";
            ViewData["descripthin"] = "ما با جدید ترین و پیشرفته ترین دوره ها آماده کمک به شما برای یادگیری برنامه نویسی هستیم";
            ViewData["addrescan"] = "/alldore";
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            return View(idore.getalldore());
        }

        [Route("getdoreby")]
        [HttpPost]
        public IActionResult getdoreby(string searchinput)
        {
            var a = idore.getdorebynamesearch(searchinput);
            return View(a);
        }

        [Route("/createnazar")]
        [HttpPost]
        [fiterkardankarbaran(1)]
        public IActionResult createnazar(nazarat nazarat)
        {
            if (ModelState.IsValid)
            {
                nazarat.nameuser = User.Identity.Name;
                nazarat.userid = idore.getintiduser(User.Identity.Name);
                if (idore.addnazar(nazarat))
                {
                    return Redirect("/dore/" + nazarat.doreid);
                }
                else
                {
                    ModelState.AddModelError("matnnazar", "متاسفانه مشکلی در ثبت نظر به وجود آمده است");
                    return Redirect("/dore/" + nazarat.doreid);
                }
            }
            else
            {
                ModelState.AddModelError("matnnazar", "لطفا فیلد متن را به درستی پر گنید");
                return Redirect("/dore/"+nazarat.doreid);
            }
        }
    
        [Route("/deletenazar")]
        [fiterkardankarbaran(3)]
        public IActionResult deletenazar(int idnazar,int iddore)
        {
            idore.deletenazar(idnazar);
            return Redirect("/dore/"+ iddore);
        }
    }
}
