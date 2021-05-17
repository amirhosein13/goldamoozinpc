using layedata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datacore
{
    public class indexback : Iindex
    {
        private context db;
        public indexback(context context)
        {
            db = context;
        }
        public indexviewmodel getindexviewmodel()
        {
            indexviewmodel indexviewmodela = new indexviewmodel();
            try
            {
                indexviewmodela.akharindoreha = db.dores.OrderByDescending(u => u.doreid).Take(12).ToList();
            }
            catch
            {
                indexviewmodela.akharindoreha = db.dores.ToList();
            }
            try
            {
                indexviewmodela.blogmaghales = db.blogmaghales.OrderByDescending(u => u.blogmaghaleid).Take(6).ToList();
            }
            catch
            {
                indexviewmodela.blogmaghales = db.blogmaghales.ToList();
            }
            try
            {
                indexviewmodela.portarafdardore = db.dores.OrderByDescending(u => u.doretedaddaneshamooz).Take(8).ToList();
            }
            catch
            {
                indexviewmodela.portarafdardore = db.dores.ToList();
            }
            return indexviewmodela;
        }
    }
}
