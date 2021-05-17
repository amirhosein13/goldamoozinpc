using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
   public class doreuser
    {
        public doreuser()
        {

        }
        [Key]
        public int doreuserid { get; set; }
        public int doreid { get; set; }
        public int userid { get; set; }
        public virtual dore Dore { get; set; }
        public virtual userbomb Userbomb { get; set; }
    }
}
