using layedata;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace datacore
{

    public class soalback : Isoalinter
    {
        private readonly context db;

        public soalback(context context)
        {
            db = context;
        }
        public bool addjavab(javab javab)
        {
            try
            {
                db.Add(javab);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool addsoal(soal soal)
        {
            try
            {
                db.Add(soal);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<soal> getallsoal()
        {
            try
            {
                return db.Soals.Include(a => a.Dore).Include(a => a.Javabs).ToList();
            }
            catch
            {
                return null;
            }
        }

        public int getidbynameuser(string name)
        {
            try
            {
                return db.userbombs.FirstOrDefault(a => a.username == name).userid;
            }
            catch
            {
                return 0;
            }
        }

        public soal getsoalbyid(int id)
        {
            try
            {
                return db.Soals.Include(a => a.Javabs).Include(b => b.Dore).FirstOrDefault(a => a.soalid == id);
            }
            catch
            {
                return null;
            }
        }

        public List<soal> getsoalbyiddore(int dore)
        {
            try
            {
                return db.Soals.Include(a => a.Javabs).Include(b => b.Dore).Where(a => a.doreid == dore).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<soal> getsoalbynamesoal(string name)
        {
            try
            {
                return db.Soals.Include(a=>a.Dore).Include(a=>a.Javabs).Where(c => c.soaltitr.Contains(name)).ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool javabsahihkon(string idusername, int idjavab)
        {
            try
            {
                var b = db.userbombs.FirstOrDefault(bb => bb.username == idusername).userid;
                var a = db.javabs.Include(aaa=>aaa.Soal).FirstOrDefault(aa => aa.javabid == idjavab);
                if (a.Soal.userid==b)
                {
                    a.pasokhdorostnood = true;
                    db.Update(a);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public bool modarsgsaya(int id)
        {
            int a = db.userbombs.FirstOrDefault(a => a.userid == id).roleid;
            if (a>2)
            {
                return true;
            }
            return false;
        }
    }
}
