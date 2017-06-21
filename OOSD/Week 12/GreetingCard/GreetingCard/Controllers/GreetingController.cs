using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreetingCard.Controllers
{
    public class GreetingController : Controller
    {
        
        public GreetingController()
        {
            //Session["selectedPicture"] = "";
            //Session["selectedGreeting"] = "";
        }
        // GET: Greeting
        public ActionResult ChoosePicture()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChooseGreeting(String ChosenPicture)
        {
            Session["selectedPicture"] = ChosenPicture;
            
            return View();
        }
        [HttpPost]
        public ActionResult ShowCard(String greetingString)
        {
            string imageString = (string)Session["selectedPicture"];
            ViewBag.selectedPicture = (string) Session["selectedPicture"];
            ViewBag.greeting = greetingString;
            return View();
        }
    }
}