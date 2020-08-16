using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniverSity.Models
{
    public class WebSiteDetails
    {
        [Display(Name = "الصورة الشخصية")]
        public string Url { get; set; }
        [Required]
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "الكلية")]
        public string Coulage { get; set; }
        [Required]
        [Display(Name = "المسمى الوظيفي")]
        public string Position { get; set; }
        [Required]
        [Display(Name = "ايميل")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "العنوان")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "رقم الهاتف")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "الفاكس")]
        public string Fax { get; set; }
        [Display(Name = "حساب الفيسبوك")]
        public string FacebookUrl { get; set; }
        [Display(Name = "حساب التويتر")]
        public string TwitterUrl { get; set; }
    }
}
