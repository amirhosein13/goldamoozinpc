using layedata;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.IO;

namespace datacore
{
    public class doreback : Idoreinter
    {
        private readonly context db;

        public doreback(context context)
        {
            db = context;
        }
        public bool adddore(dore dore)
        {
            try
            {
                db.Add(dore);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public dore getdorebyid(int id)
        {
            try
            {
                return db.dores.FirstOrDefault(aaa => aaa.doreid == id);
            }
            catch
            {
                return null;
            }
        }
        public bool deletdorebyid(int id)
        {
            try
            {
                var doresa = getdorebyid(id);
                db.dores.Remove(doresa);
                db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool doreExists(int id)
        {
            return db.dores.Any(e => e.doreid == id);
        }

        public List<dore> getalldore()
        {
            return db.dores.OrderByDescending(a => a.doreid).ToList();
        }

        public List<dore> getalldorebymodarsname(string name)
        {
            return db.dores.Where(a => a.doremodars == name).ToList();
        }


        public doreindexpage getdorekamelbyid(int id)
        {
            doreindexpage doreindexpage = new doreindexpage();
            try
            {
                doreindexpage.dorea = db.dores.FirstOrDefault(m => m.doreid == id);
            }
            catch
            {
                doreindexpage.dorea = null;
            }
            try
            {
                doreindexpage.videodore = db.videodores.Where(u => u.doreid == doreindexpage.dorea.doreid).ToList();
            }
            catch
            {
                doreindexpage.videodore = new List<videodore>();
            }
            try
            {
                doreindexpage.nazaratsvm = db.nazarats.Where(aa => aa.doreid == doreindexpage.dorea.doreid).Include(ss => ss.Nazarostads).ToList();
            }
            catch
            {
                doreindexpage.nazaratsvm = new List<nazarat>();
            }
            return doreindexpage;
        }

        public dore getdorebyname(string ids)
        {
            return db.dores.FirstOrDefault(m => m.dorename == ids);
        }

        public List<dore> getdorebynamesearch(string name)
        {
            try
            {
                return db.dores.Where(c => c.dorename.Contains(name)).ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool postftp(string fullnamea, string filenamea)
        {
            try
            {
                string filename = filenamea;
                string fullname = fullnamea;
                string server = "ftp://sdna.goldamooz.com/";
                string password = "qazwsxecdA1385";
                string username = "ftpbeferst@sdna.goldamooz.com";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, filename)));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(username, password);
                Stream ftpstream = request.GetRequestStream();
                FileStream fs = System.IO.File.OpenRead(fullname);
                byte[] buffer = new byte[200 * 1000000];
                double total = (double)fs.Length;
                int byteeread = 0;
                double read = 0;
                do
                {
                    byteeread = fs.Read(buffer, 0, 200 * 1000000);
                    ftpstream.Write(buffer, 0, byteeread);
                    read += (double)byteeread;

                } while (byteeread != 0);
                {
                    fs.Close();
                    ftpstream.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updatedore(dore dore)
        {
            try
            {
                db.Update(dore);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addnazar(nazarat nazarat)
        {
            try
            {
                db.Add(nazarat);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addnazarostad(nazarostad nazarostad)
        {
            try
            {

                db.Add(nazarostad);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getintiduser(string username)
        {
            try
            {
                return db.userbombs.FirstOrDefault(asd => asd.username == username).userid;
            }
            catch
            {

                return 0;
            }
        }

        public bool deletenazar(int idnazar)
        {
            try
            {
                var aaaa = db.nazarats.FirstOrDefault(sda => sda.nazaratid == idnazar);
                db.nazarats.Remove(aaaa);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool isteacher(string name)
        {
            var a = db.userbombs.FirstOrDefault(u => u.username == name);
            return a.roleid >= 3;
        }
    }
}
