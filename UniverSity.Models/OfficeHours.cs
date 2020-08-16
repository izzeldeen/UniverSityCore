using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniverSity.Models
{
    public class OfficeHours
    {
        public int Id { get; set; }

        [Display(Name ="بداية الساعة ")]
        public DateTime StartHours { get; set; }
        [Display(Name = "نهاية الساعة ")]
        public DateTime EndHour { get; set; }
        [Display(Name = " اليوم ")]
        public DayOfWeek Day { get; set; }
        [Display(Name = " رقم المكتب ")]
        public string OfficeNum { get; set; }



    }
}
