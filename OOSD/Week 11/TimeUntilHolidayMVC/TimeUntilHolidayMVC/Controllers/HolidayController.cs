using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeUntilHolidayMVC.Models;

namespace TimeUntilHolidayMVC.Controllers
{
    public class HolidayController : Controller
    {
        List<Holiday> myHolidays;
        Random rand;

        public HolidayController()
        {
            rand = new Random();
            myHolidays = FillHolidayList();
        }
        
        
        // GET: Holiday
        public ActionResult GetHoliday()
        {
            
            int randNum = rand.Next(3);

            Holiday singleHoliday = myHolidays[randNum];


            return View(singleHoliday);
        }

        public List<Holiday> FillHolidayList()
        {
            List<Holiday> holidayList = new List<Holiday>();
            DateTime qb = new DateTime(DateTime.Now.Year, 6, 5);
            DateTime hw = new DateTime(DateTime.Now.Year, 10, 31);
            DateTime bd = new DateTime(DateTime.Now.Year, 12, 26);

            Holiday holiday1 = new Holiday("Queens Birthday", qb, "~/queens-birthday.gif");
            Holiday holiday2 = new Holiday("Halloween", hw, "~/halloween.jpeg");
            Holiday holiday3 = new Holiday("Boxing Day", bd, "~/boxingday.jpg");

            holidayList.Add(holiday1);
            holidayList.Add(holiday2);
            holidayList.Add(holiday3);
            return holidayList;
        }
    }
}