using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bomblearn.Models;
using datacore;
using layedata;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace bomblearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAcount acount;
        Iindex indexas;
        private IViewRenderService vts;
        public HomeController(ILogger<HomeController> logger, IAcount acountback , IViewRenderService vtsp, Iindex iindex)
        {
            _logger = logger;
            acount = acountback;
            vts = vtsp;
            indexas = iindex;
        }
        [Route("login")]
        public IActionResult login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/index");
            }
            ViewBag.login = 0;
            return View();
        }

        #region register
        [HttpPost]
        [Route("register")]
        [ValidateAntiForgeryToken]
        public IActionResult register(registerviewmodel registerviewmodel)
        {
            if (!ModelState.IsValid)
            {
                return View("login");
            }
            if (acount.existusername(registerviewmodel.username))
            {
                ModelState.AddModelError("username", " این نام کاربری قبلا ثبت شده است");
                ViewBag.login = 0;
                return View("login", registerviewmodel);
            }
            if (acount.existemail(registerviewmodel.useremail))
            {
                ModelState.AddModelError("useremail", " این ایمیل قبلا ثبت شده است");
                ViewBag.login = 0;
                return View("login", registerviewmodel);
            }
            userbomb userbomb = new userbomb()
            {
                useractivatecode = Guid.NewGuid().ToString().Replace("-", ""),
                userpassword = PasswordHelper.EncodePasswordMd5(registerviewmodel.userpassword),
                useremail = registerviewmodel.useremail,
                username = registerviewmodel.username,
                useractiveaya = false,
                roleid = 1
            };
            try
            {
                acount.adduser(userbomb);
                string emailsend = vts.RenderToStringAsync("email", userbomb);
                SendEmail.Send(userbomb.useremail, "فعالسازی حساب کاربری",emailsend);
                ViewBag.login = 1;
            }
            catch
            {
                ViewBag.login = 0;
            }
            return View("login", registerviewmodel);
        }
        #endregion

        #region login
        [HttpPost]
        [Route("login")]
        public IActionResult login(string username, string userpassword)
        {
            if (!ModelState.IsValid)
            {
                return View("login");
            }
            if (acount.login(username, userpassword))
            {
                var user = acount.getuserbomb(username, userpassword);
                var claims = new List<Claim>() {
                     new Claim(ClaimTypes.NameIdentifier,user.userid.ToString()),
                     new Claim(ClaimTypes.Name,username),
                };
                var ehrazhoviat = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(ehrazhoviat);
                var propertylogin = new AuthenticationProperties
                {
                    IsPersistent = true,
                };
                HttpContext.SignInAsync(principal,propertylogin);
                ViewBag.login = 2;
                return View("login");
            }
            else
            {
                ModelState.AddModelError("username", "کاربری با این مشحصات یافت نشد/فعال نشده است");
                return View("login");
            }
        }
        #endregion

        #region activeaccount
        [Route("activeemail/{id}")]
        public IActionResult activeemail(string id)
        {
            if (acount.useractive(id))
            {
                ViewBag.login = 1;
                return View("accountlogin");
            }
            else
            {
                ViewBag.login = 2;
                return View("accountlogin");
            }
        }
        #endregion

        #region logout
        [Route("Logout")]
        public IActionResult logout()
        {

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/index");
        }
        #endregion

        #region resetpassword
        [Route("resetpassword")]
        public IActionResult resetpassword()
        {
            return View();
        }

        [HttpPost]
        [Route("resetpassword")]
        public IActionResult resetpassword(resetpasword resetpasword)
        {
            if (!ModelState.IsValid)
            {
                return View("resetpassword");
            }
            var user = acount.getuserbyemail(resetpasword.useremail);
            if (user==null)
            {
                ModelState.AddModelError("useremail", "ایمیلی که شما وارد کردید قبلا برای هیچ کاربری ثبت نشده است");
                return View("resetpassword", resetpasword);
            }
            else
            {
                try
                {
                    string emailsend = vts.RenderToStringAsync("emailresetpassword", user);
                    SendEmail.Send(user.useremail, "بازیابی رمز عبور", emailsend);
                    ViewBag.login = 1;
                    return View("resetpassword");
                }
                catch
                {
                    ModelState.AddModelError("useremail", "خطایی رخ داده است");
                    return View("resetpassword", resetpasword);
                }
             
            }
        }
        [Route("resetpasswordb/{id}")]
        public IActionResult resetpasswordb(string id)
        {
            userbomb userbomb = acount.getuserbyactivecode(id);
            resetpasswordviewmodel resetpasswordviewmodel = new resetpasswordviewmodel
            {
                activeacount = userbomb.useractivatecode
            };
            return View("resetpasswordb", resetpasswordviewmodel);
        }
        [HttpPost]
        [Route("resetpasswordb/{id}")]
        public IActionResult resetpasswordb(resetpasswordviewmodel resetpasswordviewmodelid)
        {
            if (!ModelState.IsValid)
            {
                return View("resetpasswordb", resetpasswordviewmodelid);
            }
            userbomb userbomb = acount.getuserbyactivecode(resetpasswordviewmodelid.activeacount);
            if (userbomb == null)
                return NotFound();
            string hashNewPassword = PasswordHelper.EncodePasswordMd5(resetpasswordviewmodelid.userpassword);
            userbomb.userpassword = hashNewPassword;
            acount.updateuser(userbomb);
            return View("login");
        }
        #endregion

        [Route("index")]
        public IActionResult Index()
        {
            ViewData["ogimage"] = "https://goldamooz.com/favicon.ico";
            return View(indexas.getindexviewmodel());
        }
        public IActionResult Indexa()
        {
            return Redirect("/indexa.html");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/404page")]
        public IActionResult PageNotFound()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
