using layedata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using layedata;
using System.Globalization;

namespace datacore
{
    public class paydoreback : IPaydore
    {
        private context db;
        public paydoreback(context context)
        {
            db = context;
        }

        public int adduserpay(int iduser, int iddore)
        {
            try
            {
                payuserdore payuserdore = new payuserdore();
                payuserdore.doreid = iddore;
                payuserdore.userid = iduser;
                PersianCalendar pc = new PersianCalendar();
                payuserdore.datenowbahal = pc.GetYear(DateTime.Now).ToString() + "/index" + pc.GetMonth(DateTime.Now).ToString() + "/index" + pc.GetDayOfMonth(DateTime.Now).ToString();
                payuserdore.dorostbood = false;
                var a= db.dores.FirstOrDefault(a => a.doreid == iddore);
                payuserdore.ghaymat = a.dorehgaymat;
                db.Add(payuserdore);
                db.SaveChanges();
                return db.payuserdores.OrderByDescending(a => a.doreid).FirstOrDefault().payuserid;
            }
            catch
            {
                return 0;
            }
        }

        public int getghaymatdore(int id)
        {
            return db.dores.FirstOrDefault(a => a.doreid == id).dorehgaymat;
        }

        public bool getkhariddore(string username, int id)
        {
            int b = db.userbombs.FirstOrDefault(a=>a.username==username).userid;
            return db.payuserdores.Any(a=>a.userid==b&&a.doreid==id&&a.dorostbood==true);
        }

        public int returniduserbyname(string name)
        {
            return db.userbombs.FirstOrDefault(a=>a.username==name).userid;
        }

        public payuserdore returniduserdorepay(int id)
        {
            return db.payuserdores.FirstOrDefault(a => a.payuserid == id);
        }

        public bool updatepardakht(int id)
        {
            try
            {
                var c = db.payuserdores.FirstOrDefault(a=>a.payuserid==id);
                c.dorostbood = true;
                db.Update(c);
                db.SaveChanges();
                doreuser doreusera = new doreuser();
                doreusera.userid = c.userid;
                doreusera.doreid = c.doreid;
                db.Add(doreusera);
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
