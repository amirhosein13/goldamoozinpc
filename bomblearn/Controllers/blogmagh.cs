using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using datacore;
using Microsoft.AspNetCore.Mvc;

namespace bomblearn.Controllers
{
    public class blogmagh : Controller
    {
        private Iblog bloga;
        public blogmagh(Iblog iblog)
        {
            bloga = iblog;
        }
        [Route("blog/{id}")]
        public IActionResult blog(string id)
        {
            var a = bloga.getblogbyid(Convert.ToInt32(id));
            ViewData["Title"] = a.titr;
            ViewData["descripthin"] = a.matnkootahblog;
            ViewData["addrescan"] = "blog/" + id;
            ViewData["ogimage"] = a.urlimage;
            return View(a);
        }
        [Route("allblog")]
        public IActionResult allblog()
        {
            ViewData["Title"] = "مقاله های گلد آموز";
            ViewData["descripthin"] = "ما برای بالا بردن اطلاعات شما مطالبی رو جمع آوری میکنیم و در این قالب به شما به صورت رایگان نشان میدهیم";
            ViewData["addrescan"] = "allblog";
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            return View(bloga.getallmaghale());
        }
    }
}
