using QuizWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QuizWebApplication.Controllers
{
    public class LoginController : Controller
    {
        PlayerResultDbDataContext db;

        public LoginController()
        {
            db = new PlayerResultDbDataContext();
        }
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.FailedLogin = "";
            return View("Login");
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            var players = from p in db.tblPlayers
                          where (p.PlayerName == user.Name) && (p.PlayerPassword == user.Password)
                          select p;
            if(players.Any())
            {
                //There is a player found that matches username and password
                String username = user.Name;

                tblPlayer player = players.First();
                int x = player.PlayerID;
                Session["id"] = player.PlayerID;
                Session["name"] = player.PlayerName;
                

                return RedirectToAction("Index", "Quiz");
            }
            else
            {
                //Login Failed
                //ViewBag.FailedLogin = "Incorrect Username or Password";
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
                return View("Login");
            }

            return RedirectToAction("Index", "Quiz");
        }

        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(String username, String pass1, String pass2)
        {
            if(username == "" || pass1 == "" || pass2 == "")
            {
                ViewBag.Error = "Must Fill Out Fields";
            }
            else if(pass1 == pass2)
            {
                //Register User To Database
                //Create player object
                tblPlayer player = new tblPlayer
                {
                    PlayerName = username,
                    PlayerPassword = pass1
                };

                //Add new player to tblPlayers collection
                db.tblPlayers.InsertOnSubmit(player);

                //submit changes to db
                try
                {
                    db.SubmitChanges();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }            

            }
            else
            {
                ViewBag.Error = "Passwords Do Not Match";
                return View();
            }
            return View();            
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Login");
        }
    }
}