using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int count = 0;
            List<int> lYear = new List<int>();
            for (int i = 2500; i <= 2600; i++)
            {
                int year = i - 543;
                DateTime date1 = new DateTime(year, 1, 1);
                DateTime date2 = new DateTime(year, 1, 30);
                DateTime date3 = new DateTime(year, 1, 31);
                bool sat = date1.DayOfWeek == DayOfWeek.Saturday;
                bool sun = date2.DayOfWeek == DayOfWeek.Sunday;
                bool mon = date3.DayOfWeek == DayOfWeek.Monday;
                if (sat && sun && mon)
                {
                    count++;
                    lYear.Add(i);
                }
            }


            int num = count;
            List<int> lYeardoo = lYear;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}