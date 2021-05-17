using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class nazarat
    {
        public nazarat()
        {
                
        }
        [Key]
        public int nazaratid { get; set; }
        public string nameuser { get; set; }
        public string matnnazar { get; set; }
        public int userid { get; set; }
        public int doreid { get; set; }

        public virtual dore Dore { get; set; }
        public virtual userbomb Userbomb { get; set; }
        public virtual List<nazarostad> Nazarostads { get; set; }
    }
}
