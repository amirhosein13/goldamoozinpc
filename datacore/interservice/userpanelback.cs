using layedata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datacore
{
    public class userpanelback : Iinteruserpanel
    {
        context db;
        public userpanelback(context contextb)
        {
            db = contextb;
        }
        public List<dore> getalldorebyusername(string name)
        {
            try
            {
                var a = db.userbombs.FirstOrDefault(aa => aa.username == name);
                var b = db.Doreusers.Where(bb => bb.userid == a.userid).ToList();
                List<dore> returnsho = new List<dore>();
                foreach (var item in b)
                {
                    returnsho.Add(db.dores.FirstOrDefault(cc => cc.doreid == item.doreid));
                }
                return returnsho;
            }
            catch
            {
                return null;
            }
        }

        public List<javab> getalljavabhayam(string name)
        {
            try
            {
                var a = db.userbombs.FirstOrDefault(aa => aa.username == name);
                return db.javabs.Include(si => si.Soal).Where(bb => bb.userid == a.userid).ToList();
            }
            catch
            {
                return null;
            }
        }

        public int getdorecountbyname(string name)
        {
            try
            {
                var a = db.userbombs.FirstOrDefault(aa => aa.username == name);
                return db.Doreusers.Where(bb=>bb.userid==a.userid).Count();
            }
            catch
            {
                return 0;
            }
        }

        public List<payuserdore> getfactorbyname(string name)
        {
            try
            {
                var a = db.userbombs.FirstOrDefault(aa => aa.username == name);
                return db.payuserdores.Where(bb => bb.userid == a.userid).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<soal> getsoalbynameuser(string name)
        {
            try
            {
                var a = db.userbombs.FirstOrDefault(aa => aa.username == name);
                return db.Soals.Include(j=>j.Javabs).Include(jj=>jj.Dore).Where(bb => bb.userid == a.userid).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
