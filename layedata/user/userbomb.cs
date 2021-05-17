using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class userbomb
    {
        public userbomb()
        {
                
        }
        [Key]
        public int userid { get; set; }
        [Display(Name ="نام کاربری")]
        [Required(ErrorMessage ="لطفا فیلد {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "نام کاربری شما بیشتر از 30 کاراکتر دارد")]
        public string username { get; set; }
        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string userpassword { get; set; }
        [Display(Name = "آدرس ایمیل")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [EmailAddress(ErrorMessage ="لطفا ایمیل صحیح وارد کنید")]
        public string useremail { get; set; }
        [Display(Name = "کد اکتیو")]
        public string useractivatecode { get; set; }
        [Display(Name = "اکتیو شد؟")]
        public bool useractiveaya { get; set; }
        public int roleid { get; set; }
        public virtual role role { get; set; }
        public virtual List<doreuser> Doreusers { get; set; }
        public virtual List<javab> Javabs { get; set; }
        public virtual List<soal> Soals { get; set; }
        public virtual List<blogmaghale> Blogmaghales { get; set; }
        public virtual List<nazarat> Nazarats { get; set; }
    }
}
