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
        [Required(ErrorMessage = "يجب ادخال الاسم")]
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Required(ErrorMessage = "يجب ادخال الكلية")]
        [Display(Name = "الكلية")]
        public string Coulage { get; set; }
        [Required(ErrorMessage = "يجب ادخال الوظيفي")]
        [Display(Name = "المسمى الوظيفي")]
        public string Position { get; set; }
        [Required(ErrorMessage = "يجب ادخال ايميل")]
        [Display(Name = "ايميل")]
        public string Email { get; set; }
        [Required(ErrorMessage = "يجب ادخال العنوان")]
        [Display(Name = "العنوان")]
        public string Address { get; set; }
        [Required(ErrorMessage = "يجب ادخال الهاتف")]
        [Display(Name = "رقم الهاتف")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "يجب ادخال الفاكس")]
        [Display(Name = "الفاكس")]
        public string Fax { get; set; }
        [Display(Name = "حساب الفيسبوك")]
        public string FacebookUrl { get; set; }
        [Display(Name = "حساب التويتر")]
        public string TwitterUrl { get; set; }
    }
}
