using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace layedata
{
   public class videodore
    {
        public videodore()
        {

        }

        [Key]
        public int videoid { get; set; }
         [Display(Name ="نام جلسه")]
        [Required(ErrorMessage ="لطفا فیلد {0} را وارد کنید")]
        [MaxLength(80,ErrorMessage ="نام جلسه بیشتر از 80 کاراکتر است")]
        public string videoname { get; set; }

        [Display(Name = "متن جلسه")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string videomatn { get; set; }

        [Display(Name = "آدرس ویدعو")]
        public string urlvideo { get; set; }
        public int doreid { get; set; }

        public virtual dore dore { get; set; }
        public virtual List<nazaratvideo> Nazaratvideos { get; set; }
    }
}
