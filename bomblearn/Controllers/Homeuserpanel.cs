using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using datacore;
using Microsoft.AspNetCore.Mvc;

namespace bomblearn.Controllers
{
    [fiterkardankarbaran(3)]
    public class Homeuserpanel : Controller
    {
        private Iuser interuser;
        Iinteruserpanel Iinteruserpanel;
        public Homeuserpanel(Iuser iuser, Iinteruserpanel iinteruserpanela)
        {
            interuser = iuser;
            Iinteruserpanel = iinteruserpanela;
        }
        [Route("userpanel")]
        public IActionResult doreuserpanel()
        {
            ViewBag.isteacher = interuser.getbooldastresuser(User.Identity.Name,2);
            ViewBag.dorecount = Iinteruserpanel.getdorecountbyname(User.Identity.Name);
            return View(Iinteruserpanel.getalldorebyusername(User.Identity.Name));
        }
        [Route("soalhayeman")]
        public IActionResult soalhayeman()
        {
            ViewBag.isteacher = interuser.getbooldastresuser(User.Identity.Name, 2);
            ViewBag.dorecount = Iinteruserpanel.getdorecountbyname(User.Identity.Name);
            return View(Iinteruserpanel.getsoalbynameuser(User.Identity.Name));
        }
        [Route("pasokhhayeman")]
        public IActionResult pasokhhayeman()
        {
            ViewBag.isteacher = interuser.getbooldastresuser(User.Identity.Name, 2);
            ViewBag.dorecount = Iinteruserpanel.getdorecountbyname(User.Identity.Name);
            return View(Iinteruserpanel.getalljavabhayam(User.Identity.Name));
        }
        [Route("ticketme")]
        public IActionResult ticketme()
        {
            ViewBag.isteacher = interuser.getbooldastresuser(User.Identity.Name, 2);
            ViewBag.dorecount = Iinteruserpanel.getdorecountbyname(User.Identity.Name);
            return View();
        }
        [Route("factor")]
        public IActionResult factor()
        {
            ViewBag.isteacher = interuser.getbooldastresuser(User.Identity.Name, 2);
            ViewBag.dorecount = Iinteruserpanel.getdorecountbyname(User.Identity.Name);
            return View(Iinteruserpanel.getfactorbyname(User.Identity.Name));
        }
    }
}
