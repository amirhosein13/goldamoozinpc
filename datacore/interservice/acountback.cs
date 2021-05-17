using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using layedata;

namespace datacore
{
    public class acountback : IAcount
    {
       private context db;
        public acountback(context dbs)
        {
            db = dbs; 
        }

        public int adduser(userbomb userbomb)
        {
            db.userbombs.Add(userbomb);
            db.SaveChanges();
            return userbomb.userid;
        }

        public bool existemail(string emailaddres)
        {
            return db.userbombs.Any(u => u.useremail == emailaddres);
        }

        public bool existusername(string username)
        {
            return db.userbombs.Any(u=>u.username==username);
        }

        public userbomb getuserbomb(string username, string password)
        {
            string hashpassword = PasswordHelper.EncodePasswordMd5(password);
            return db.userbombs.SingleOrDefault(u => u.username == username && u.userpassword == hashpassword);
        }

        public userbomb getuserbyactivecode(string activecode)
        {
            return db.userbombs.SingleOrDefault(u=>u.useractivatecode==activecode);
        }

        public userbomb getuserbyemail(string email)
        {
            return db.userbombs.SingleOrDefault(u=>u.useremail==email);
        }

        public bool login(string username, string password)
        {
            string hashpassword = PasswordHelper.EncodePasswordMd5(password);
            return db.userbombs.Any(u=>u.username==username&&u.userpassword==hashpassword&&u.useractiveaya==true);
        }

        public void updateuser(userbomb userbomb)
        {
            db.Update(userbomb);
            db.SaveChanges();
        }

        public bool useractive(string id)
        {
            var user = db.userbombs.SingleOrDefault(u => u.useractivatecode == id);
            if (user == null || user.useractiveaya)
                return false;

            user.useractiveaya = true;
            user.useractivatecode = Guid.NewGuid().ToString().Replace("-", "");
            db.SaveChanges();

            return true;
        }
    }
}
