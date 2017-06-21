using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SavingStateDemo.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Index()
        {
            if(Session["cityList"] == null)
            {
                Session["cityList"] = GetCityList();
            }
            if(Session["listCount"] == null)
            {
                Session["listCount"] = 0;
            }            

            int currentNum = (int)Session["listCount"] % 3;
            List<String> myCityList = (List<String>)Session["cityList"];
            ViewBag.cityName = myCityList[currentNum];

            int count = (int)Session["listCount"];
            count++;
            Session["listCount"] = count;

            return View();
        }

        public List<string> GetCityList()
        {
            List<string> cityList = new List<string>();
            cityList.Add("Auckland");
            cityList.Add("Balclutha");
            cityList.Add("Christchurch");

            return cityList;
        }
    }
}