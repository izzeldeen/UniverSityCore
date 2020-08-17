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
        [Required(ErrorMessage ="يجب ادخال العنوان")]
        [Display(Name = "العنوان")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "يجب ادخال التفاصيل")]
        [Display(Name ="تفاصيل")]
        public string Description { get; set; }
    }
}
