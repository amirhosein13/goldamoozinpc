using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace layedata
{
    public class javab
    {
        public javab()
        {

        }
        [Key]
        public int javabid { get; set; }
        [Display(Name = "متن جواب")]
        [Required(ErrorMessage = "لطفا فیلد {0} را وارد کنید")]
        public string javabmatn { get; set; }
        public string? zamimejavab { get; set; }
        public bool? modarsgofte { get; set; }
        public bool? pasokhdorostnood { get; set; }
        public string? javabdahande { get; set; }

        public int? soalid { get; set; }
        public int? userid { get; set; }

        public virtual userbomb Userbomb { get; set; }
        public virtual soal Soal { get; set; }

    }
}
