using datacore;
using layedata;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bomblearn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mobileapi : ControllerBase
    {
        private IAcount acount;
        context db;
        private IViewRenderService vts;
        public mobileapi(context context,IAcount acounta,IViewRenderService viewRenderService)
        {
            db = context;
            acount = acounta;
            vts = viewRenderService;
        }

        [Produces("application/json")]
        [HttpGet("getdore")]
        public async Task<List<dore>> getdore()
        {
            try
            {
                return db.dores.ToList();
            }
            catch
            {
                return null;
            }
        }

        [Produces("application/json")]
        [HttpGet("getsoal")]
        public async Task<List<soal>> getsoal()
        {
            try
            {
                return db.Soals.ToList();
            }
            catch
            {
                return null;
            }
        }
        [Produces("application/json")]
        [HttpGet("vorood")]
        public async Task<string> vorood(string username, string password)
        {
            try
            {
                var a = db.userbombs.FirstOrDefault(aa => aa.username == username);
                if (a != null)
                {
                    if (a.userpassword == PasswordHelper.EncodePasswordMd5(password))
                    {
                        if (a.useractiveaya)
                        {
                            return "ورود با موفقیت انجام شد";
                        }
                        else
                        {
                            return "(ایمیل کاربر فعال نشده است  (ایمیلتون را چک کنید";
                        }
                    }
                    else
                    {
                        return "رمز عبور اشتباه بوده است";
                    }
                }
                else
                {
                    return "همچین کاربری پیدا نشد";
                }
            }
            catch
            {
                return "در روند کار مشکلی پیش آمده است لطفا چند لحظه دیگر دوباره تلاش کنید";
            }
        }
        [Produces("application/json")]
        [HttpGet("sabtnam")]
        public async Task<string> sabtnam(string username, string password,string email)
        {
            if (db.userbombs.Any(aa=>aa.username==username))
            {
                return "این نام کاربری قبلا ثبت شده است";
            }
            else
            {
                if (db.userbombs.Any(aa=>aa.useremail==email))
                {
                    return "این ایمیل قبلا ثبت شده است";
                }
                else
                {
                    userbomb userbomb = new userbomb()
                    {
                        useractivatecode = Guid.NewGuid().ToString().Replace("-", ""),
                        userpassword = PasswordHelper.EncodePasswordMd5(password),
                        useremail = email,
                        username = username,
                        useractiveaya = false,
                        roleid = 1
                    };
                    try
                    {
                        acount.adduser(userbomb);
                        string emailsend = vts.RenderToStringAsync("email", userbomb);
                        SendEmail.Send(userbomb.useremail, "فعالسازی حساب کاربری", emailsend);
                        return "ثبت نام با موفیت انجام شد لطفا ایمیل خود را جک کنید";
                    }
                    catch
                    {
                        return "در سیستم مشکلی پیش آمده اصت لطفا جند لحظه دیگر تلاش کنید";
                    }
                }
            }
        }
    }
}
