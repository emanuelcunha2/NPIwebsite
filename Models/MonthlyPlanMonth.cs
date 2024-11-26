using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace NPI.Models
{
    public class MonthlyPlanMonth
    {
        public int Number { get; set; }
        public List<MonthlyPlanWeek> Weeks { get; set; }
        public MonthlyPlanMonth(DateTime date)
        {
            GetMonthlyCalendarPlanData(date);
        }

        public void GetMonthlyCalendarPlanData(DateTime date)
        {
            // Set date as the first day of the month
            date = new DateTime(date.Year, date.Month, 1);

            Weeks = new List<MonthlyPlanWeek>();
            this.Number = date.Month;
            int startWeekDay = (int)date.DayOfWeek;

            // Get starting day
            DateTime startDate = date.AddDays(-startWeekDay);

            // Get Week number 
            System.Globalization.Calendar calendar = new GregorianCalendar();
            int startWeekNumber = calendar.GetWeekOfYear(date.AddDays(-startWeekDay), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
            startDate = startDate.AddDays(-1);

            // Add each Week
            for (int countWeeks = 1; countWeeks <= 6; countWeeks++)
            {
                MonthlyPlanWeek week = new MonthlyPlanWeek();
                week.Number = startWeekNumber + (countWeeks - 1);

                // Add each Day of the Week
                for (int countDays = 1; countDays <= 7; countDays++)
                {
                    MonthlyPlanDay day = new MonthlyPlanDay();
                    day.Date = startDate.AddDays(countDays + (7 * (countWeeks - 1)));
                    // Set workday status
                    if((int)day.Date.DayOfWeek != 0 && (int)day.Date.DayOfWeek != 6) { day.IsWorkday = true; }

                    // Set holiday status
                    // TODO:
                    week.Days.Add(day);
                }
                this.Weeks.Add(week);
            }
        }


    }
}