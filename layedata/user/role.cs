using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class role
    {
        public role()
        {
                
        }
        [Key]
        public int roleid { get; set; }
        [Display(Name = "نام رل")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string rolename { get; set; }

        public virtual List<userbomb> userbombs { get; set; }
    }
}
