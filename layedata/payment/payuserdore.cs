using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class payuserdore
    {
        public payuserdore()
        {
                
        }
        [Key]
        public int payuserid { get; set; }
        public int userid { get; set; }
        public int doreid { get; set; }
        public int ghaymat { get; set; }
        public bool dorostbood { get; set; }
        public string? datenowbahal { get; set; }
    }
}
