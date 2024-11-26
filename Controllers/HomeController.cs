using NPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            MonthlyPlanMonth month = new MonthlyPlanMonth(DateTime.Today.AddDays(10));
            month.Weeks[1].Events.Add(new MonthlyPlanEvent() { 
                BIF = "EA912319",
                Project = "MIB3 CL3D",
                Qty = "12135",
                Var = "SMT",
                PRS = "Jorge Ribeiro",
                EventColor = MonthlyPlanEvent.Color.Orange
            });

            month.Weeks[2].Events.Add(new MonthlyPlanEvent()
            {
                BIF = "EA912319",
                Project = "MIB3 CL3D",
                Qty = "12135",
                Var = "SMT",
                PRS = "Jorge Ribeiro",
                EventColor = MonthlyPlanEvent.Color.Green
            });

            month.Weeks[2].Events.Add(new MonthlyPlanEvent()
            {
                BIF = "EA912319",
                Project = "MIB3 CL3D",
                Qty = "12135",
                Var = "SMT",
                PRS = "Jorge Ribeiro",
                EventColor = MonthlyPlanEvent.Color.Blue
            });


            month.Weeks[2].Events.Add(new MonthlyPlanEvent()
            {
                BIF = "EA912319",
                Project = "MIB3 CL3D",
                Qty = "12135",
                Var = "SMT",
                PRS = "Jorge Ribeiro",
                EventColor = MonthlyPlanEvent.Color.Yellow
            });

            month.Weeks[2].Events.Add(new MonthlyPlanEvent()
            {
                BIF = "EA912319",
                Project = "MIB3 CL3D",
                Qty = "12135",
                Var = "SMT",
                PRS = "Jorge Ribeiro",
                EventColor = MonthlyPlanEvent.Color.Red
            });

            month.Weeks[2].Events.Add(new MonthlyPlanEvent()
            {
                BIF = "EA912319",
                Project = "MIB3 CL3D",
                Qty = "12135",
                Var = "SMT",
                PRS = "Jorge Ribeiro",
                EventColor = MonthlyPlanEvent.Color.Orange
            });

            month.Weeks[5].Events.Add(new MonthlyPlanEvent()
            {
                BIF = "EA912319",
                Project = "MIB3 CL3D",
                Qty = "12135",
                Var = "SMT",
                PRS = "Jorge Ribeiro",
                EventColor = MonthlyPlanEvent.Color.Yellow
            });



            month.Weeks[1].Days[3].IsHoliday = true;
            month.Weeks[5].Days[5].IsHoliday = true;

            ViewBag.Month = month;
            
            List<String> daysWeek = new List<String>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            List<String> workingDaysWeek = new List<String>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            ViewBag.Days = workingDaysWeek;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}