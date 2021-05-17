using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class soal
    {
        public soal()
        {

        }
        [Key]
        public int soalid { get; set; }
        [Display(Name = "تیتر سوال")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string soaltitr { get; set; }
        [Display(Name = "متن سوال")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string soalmatn { get; set; }
        public string zamimesoal { get; set; }
        public int doreid { get; set; }
        public int userid { get; set; }

        public virtual userbomb Userbomb { get; set; }
        public virtual dore Dore { get; set; }
        public virtual List<javab> Javabs { get; set; }
    }
}
