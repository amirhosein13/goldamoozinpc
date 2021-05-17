using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bomblearn.Controllers
{
    public class peeshraftecontroller : Controller
    {
        [Route("indexpeeshrafte")]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
