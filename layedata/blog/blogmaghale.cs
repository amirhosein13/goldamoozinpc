using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace layedata
{
   public class blogmaghale
    {

        public blogmaghale()
        {

        }
        [Key]
        public int blogmaghaleid { get; set; }
        [Display(Name = "تیتر")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string titr { get; set; }
        [Display(Name = "متن کوتاه")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string matnkootahblog { get; set; }
        [Display(Name = "متن اصلی")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string matnkamelblog { get; set; }
        [Display(Name = "عکس")]
        public string urlimage { get; set; }
        public string usernamemodars { get; set; }
        public int userid { get; set; }
        public virtual userbomb userbomb { get; set; }
    }
}
