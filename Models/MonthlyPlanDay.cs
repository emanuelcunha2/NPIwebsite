using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPI.Models
{
    public class MonthlyPlanDay
    {
        public DateTime Date {  get; set; }
        public bool IsHoliday { get; set; }
        public bool IsWorkday { get; set; }
        public MonthlyPlanDay() 
        {
            IsHoliday = false;
            IsWorkday = false;
        }
    }
}