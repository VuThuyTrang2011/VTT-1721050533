using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VTT1721050533_.Models
{
    public class Lecture : Person
    {
        [StringLength(50)]
        [Display(Name = "Khoa")]
        public string Faculty { get; set; }
        [StringLength(50)]
        [Display(Name = "Phòng")]
        public string Department { get; set; }
    }
}