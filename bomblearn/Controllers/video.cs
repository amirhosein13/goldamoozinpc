using datacore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bomblearn.Controllers
{
    public class video : Controller
    {
        IVideo videoa;
        public video(IVideo videoaa)
        {
            videoa = videoaa;
        }
        [Route("/video/{id}")]
        public IActionResult videodetail(string id)
        {
            var aa = videoa.getvmvideopagebyidvideo(Convert.ToInt32(id));
            ViewData["Title"] = aa.videodorea.videoname;
            ViewData["descripthin"] = aa.videodorea.videomatn;
            ViewData["addrescan"] = "/video/" + id;
            ViewData["ogimage"] = aa.dorea.doreimageurl;
            if (User.Identity.IsAuthenticated)
            {
                if (videoa.isteacher(User.Identity.Name))
                {
                    ViewBag.isteacher = true;
                }
                else
                {
                    ViewBag.isteacher=false;
                }
            }
            else
            {
                ViewBag.isteacher = false;
            }
            return View(aa);
        }
        [Route("/createnazarvideo")]
        [HttpPost]
        [fiterkardankarbaran(1)]
        public IActionResult createnazarvideo(string matnnazar,string videoid)
        {
            videoa.createnazarvideo(matnnazar,videoid,User.Identity.Name);
            return Redirect("/video/"+videoid);
        }
        [Route("/deletenazar/{id}")]
        [fiterkardankarbaran(3)]
        public IActionResult deletenazar(string id)
        {
           int videoidredirect=videoa.getidvideobynazar(Convert.ToInt32(id));
            videoa.deletenazar(Convert.ToInt32(id));
            return Redirect("/video/" + videoidredirect);
        }
    }
}
