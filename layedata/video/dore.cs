using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace layedata
{
    public class dore
    {
        public dore()
        {

        }
        [Key]
        public int doreid { get; set; }
        [Display(Name = "نام دوره")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [MaxLength(80,ErrorMessage = " نام دوره بیشتر از 80 کاراکتر است")]
        public string dorename { get; set; }
        [Display(Name = "نام مدرس دوره")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string doremodars { get; set; }
        [Display(Name = "قیمت دوره")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public int dorehgaymat { get; set; }
        [Display(Name = "متن کوتاه")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string shortmatn { get; set; }
        [Display(Name = "وضعیت برگزاری")]
        public bool dorebargozary { get; set; }
        [Display(Name = "تعداد جلسه دوره")]
        public int doretedadgalase { get; set; }
        [Display(Name = "تعداد دانشجو")]
        public int doretedaddaneshamooz { get; set; }
        [Display(Name = "زمان دوره")]
        public string doretedadsaatbargozary { get; set; }
        [Display(Name = "سطح دوره")]
        public string doresath { get; set; }
        [Display(Name = "تاریخ بروزرسانی")]
        public string doreakharinberoozresany { get; set; }
        [Display(Name = "عکس دوره")]
        public string doreimageurl { get; set; }
        [Display(Name = "متن دوره")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string dorematn { get; set; }
        public virtual List<doreuser> Doreusers { get; set; }
        public virtual List<videodore> videodores { get; set; }
        public virtual List<soal> Soals { get; set; }
        public virtual List<nazarat> Nazarats { get; set; }
    }
}
