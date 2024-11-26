using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPI.Models
{
    public class MonthlyPlanEvent
    {
        public enum Color
        {
            Blue,
            Green,
            Yellow,
            Orange,
            Red
        }

        public string Project {  get; set; }
        public string BIF { get; set; }
        public string Qty { get; set; }
        public string Var { get; set; }
        public string Category { get; set; }
        public string PRS { get; set; }

        public Color EventColor { get; set; }
        
        public MonthlyPlanEvent()
        { 
        }
    }
}