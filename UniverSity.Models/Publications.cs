using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace UniverSity.Models
{
    public class Publications
    {
        [Display(Name ="رقم الأعلان")]
        public int Id { get; set; }

        [Display(Name ="الكاتب")]
        public string Author { get; set; }
        [Display(Name = "العنوان")]
        public string Title { get; set; }
        [Display(Name = "النص")]
        public string Description { get; set; }


    }
}
