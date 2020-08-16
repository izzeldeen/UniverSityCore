using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniverSity.Models
{
    public class Post
    {
        [Display(Name ="رقم المدونة")]
        public int Id { get; set; }
        [Required]
        [Display(Name ="العنوان")]
        public string Subject { get; set; }
        [Required]
        [Display(Name ="التفاصيل")]
        public string Description { get; set; }
    }
}
