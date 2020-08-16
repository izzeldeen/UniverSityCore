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

        [Required]
        [Display(Name = "المادة ")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "تفاصيل المادة")]
        public string Description { get; set; }


    }
}
