using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniverSity.Models
{
    public class Announcement
    {
        [Display(Name ="رقم الأعلان")]
        public int Id { get; set; }

        [Display(Name="العنوان")]
        public string Subject { get; set; }
        [Display(Name = "التفاصيل")]
        public string Descrption { get; set; }
    }
}
