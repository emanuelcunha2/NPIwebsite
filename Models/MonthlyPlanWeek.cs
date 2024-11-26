using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPI.Models
{
    public class MonthlyPlanWeek
    {
        public int Number {  get; set; }
        public List<MonthlyPlanDay> Days { get; set; }
        public List<MonthlyPlanEvent> Events { get; set; }
        public MonthlyPlanWeek() 
        {
            Days = new List<MonthlyPlanDay>();
            Events = new List<MonthlyPlanEvent>();
        }
    }
    
}