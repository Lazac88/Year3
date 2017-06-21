using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeUntilHolidayMVC.Models
{
    public class Holiday
    {
        public string holidayName { get; set; }
        private DateTime holidayDate { get; set; }

        public string imagePath { get; set; }

        public Holiday(String holidayName, DateTime holidayDate, string imagePath)
        {
            this.holidayDate = holidayDate;
            this.holidayName = holidayName;
            this.imagePath = imagePath;
        }

        public string GetDaysToHoliday()
        {
            DateTime today = DateTime.Now;
            double days = Math.Round((holidayDate - today).TotalDays, 0);
            if(days < 0)
            {
                days += 365;
            }
            return days.ToString();
        }
    }
}