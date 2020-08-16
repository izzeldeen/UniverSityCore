using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniverSity.Models
{
    public class Cv
    {
        [Display(Name ="رقم")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "العنوان")]
        public string Subject { get; set; }
        [Required]
        [Display(Name ="تفاصيل")]
        public string Description { get; set; }
    }
}
