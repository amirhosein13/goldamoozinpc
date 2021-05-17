using layedata;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace datacore
{
    public class videoback : IVideo
    {
        private readonly context db;

        public videoback(context context)
        {
            db = context;
        }
        public bool addvideo(videodore videodore)
        {
            try
            {
                db.Add(videodore);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getidbynameuser(string nameuser) {
            return db.userbombs.FirstOrDefault(u=>u.username==nameuser).userid;
        }
        public bool createnazarvideo(string matnnazara, string videoida,string nameuser)
        {
            try
            {
                nazaratvideo nazaratvideo = new nazaratvideo() {
                    matnnazarvideo = matnnazara,
                    videoid = Convert.ToInt32(videoida),
                    nameuser = nameuser,
                    userid = getidbynameuser(nameuser),
                };
                db.Add(nazaratvideo);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deletebyid(int id)
        {
            try
            {
                db.videodores.Remove(db.videodores.Find(id));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<videodore> getallvideo()
        {
            return db.videodores.Include(v => v.dore).ToList();
        }

        public List<videodore> getallvideobyid(int id)
        {
            return db.videodores.Include(v => v.dore).Where(u => u.doreid == id).ToList();
        }

        public videodore getvideobyid(int id)
        {
            return db.videodores.Include(v => v.dore).FirstOrDefault(u => u.videoid == id);
        }

        public vmvideopage getvmvideopagebyidvideo(int idvideo)
        {
            vmvideopage vmvideopage = new vmvideopage();
            vmvideopage.nazaratvideo = db.nazaratvideos.Where(u => u.videoid == idvideo).ToList();
            vmvideopage.videodorea = db.videodores.FirstOrDefault(u => u.videoid == idvideo);
            vmvideopage.dorea = db.dores.FirstOrDefault(u => u.doreid == vmvideopage.videodorea.doreid);
            return vmvideopage;
        }

        public bool uodatevideo(videodore videodore)
        {
            try
            {
                db.Update(videodore);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool videodoreExists(int id)
        {
            return db.videodores.Any(e => e.videoid == id);
        }

        public bool isteacher(string username)
        {
            if (db.userbombs.FirstOrDefault(u=>u.username==username).roleid>=3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deletenazar(int id)
        {
            try
            {
                db.Remove(db.nazaratvideos.FirstOrDefault(u=>u.nazaratvideoid==id));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getidvideobynazar(int id)
        {
            return db.nazaratvideos.FirstOrDefault(u => u.nazaratvideoid == id).videoid;
        }
    }
}
