using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace datacore
{
    public class registerviewmodel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [MaxLength(30, ErrorMessage = "نام کاربری شما بیشتر از 30 کاراکتر دارد")]
        public string username { get; set; }
        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "پسورد شما بیشتر از 20 کاراکتر دارد")]
        public string userpassword { get; set; }
        [Display(Name = "تکرار پسورد")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "پسورد شما بیشتر از 20 کاراکتر دارد")]
        [Compare("userpassword", ErrorMessage ="رمز عبور با تکرارش مغایرت دارد")]
        public string reuserpassword { get; set; }
        [Display(Name = "آدرس ایمیل")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل صحیح وارد کنید")]
        public string useremail { get; set; }
    }
    public class resetpasword
    {
        [Display(Name = "آدرس ایمیل")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل صحیح وارد کنید")]
        public string useremail { get; set; }
    }
    public class resetpasswordviewmodel
    {
        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "پسورد شما بیشتر از 20 کاراکتر دارد")]
        public string userpassword { get; set; }
        [Display(Name = "تکرار پسورد")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "پسورد شما بیشتر از 20 کاراکتر دارد")]
        [Compare("userpassword", ErrorMessage = "رمز عبور با تکرارش مغایرت دارد")]
        public string reuserpassword { get; set; }
        public string activeacount { get; set; }
    }
}
