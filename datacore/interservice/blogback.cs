using layedata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datacore
{
    public class blogback : Iblog
    {
        private readonly context db;

        public blogback(context context)
        {
            db = context;
        }

        public List<blogmaghale> getallmaghale()
        {
            return db.blogmaghales.OrderByDescending(a=>a.blogmaghaleid).ToList();
        }

        public blogmaghale getblogbyid(int id)
        {
            return db.blogmaghales.FirstOrDefault(a=>a.blogmaghaleid==id);
        }
    }
}
