using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class nazaratostadvideo
    {
        public nazaratostadvideo()
        {

        }
        [Key]
        public int nazaraostadid { get; set; }
        public string nameostad { get; set; }
        public string matnnazarostad { get; set; }
        public int nazaratvideoid { get; set; }
        public int userid { get; set; }

        public virtual nazaratvideo Nazaratvideo { get; set; }
        public virtual userbomb Userbomb { get; set; }
    }
}
