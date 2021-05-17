using System;
using System.Collections.Generic;
using System.Text;
using layedata;

namespace datacore
{
   public interface IAcount
    {
        public bool existusername(string username);
        public bool existemail(string emailaddres);
        public int adduser(userbomb userbomb);
        public bool login(string username,string password);
        bool useractive(string id);
        userbomb getuserbomb(string username, string password);
        userbomb getuserbyemail(string email);
        userbomb getuserbyactivecode(string activecode);
        void updateuser(userbomb userbomb);
    }
}
