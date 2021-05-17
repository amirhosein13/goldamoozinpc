using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class nazaratvideo
    {
        public nazaratvideo()
        {

        }
        [Key]
        public int nazaratvideoid { get; set; }
        public string nameuser { get; set; }
        public string matnnazarvideo { get; set; }
        public int userid { get; set; }
        public int videoid { get; set; }

        public virtual videodore Videodore { get; set; }
        public virtual userbomb Userbomb { get; set; }
        public virtual List<nazaratostadvideo> Nazaratostadvideos { get; set; }
    }
}
