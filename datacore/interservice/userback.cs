using layedata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datacore
{
    public class userback : Iuser
    {
        private readonly context db;

        public userback(context context)
        {
            db = context;
        }

        public bool getbooldastresuser(string id, int idrole)
        {
            var aa= db.userbombs.Where(u => u.username == id).FirstOrDefault().roleid;
            if (idrole<=aa)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getroleiduser(string id)
        {
            return db.userbombs.Where(u => u.username == id).FirstOrDefault().roleid;
        }
    }
}
