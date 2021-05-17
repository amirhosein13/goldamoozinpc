using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class nazarostad
    {
        public nazarostad()
        {
                
        }
        [Key]
        public int nazaraostadid { get; set; }
        public string nameostad { get; set; }
        public string matnnazarostad { get; set; }
        public int nazaratid { get; set; }
        public int userid { get; set; }

        public virtual nazarat Nazarat { get; set; }
        public virtual userbomb Userbomb { get; set; }
    }
}
