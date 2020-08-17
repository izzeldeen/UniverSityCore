using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniverSity.Models
{
    public class Courses
    {
        [Display(Name = "رقم المادة")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="يجب ادخال المادة")]
        [Display(Name = "المادة ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "يجب ادخال تفاصيل")]
        [Display(Name = "تفاصيل المادة")]
        public string Description { get; set; }


    }
}
