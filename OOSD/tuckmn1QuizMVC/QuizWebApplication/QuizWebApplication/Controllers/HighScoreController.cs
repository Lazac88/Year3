using QuizWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizWebApplication.Controllers
{
    public class HighScoreController : Controller
    {
        PlayerResultDbDataContext db;

        public HighScoreController()
        {
            db = new PlayerResultDbDataContext();
        }

        public bool CheckLoggedIn()
        {
            bool loggedIn = false;
            if (Session["name"] != null)
            {
                loggedIn = true;
            }
            return loggedIn;
        }

        // GET: HighScore
        public ActionResult Index()
        {
            //Check User Is Logged In
            if (CheckLoggedIn())
            {
                //Grab results for current month
                var filteredResults = from r in db.tblResults
                                      join p in db.tblPlayers
                                      on r.PlayerID equals p.PlayerID
                                      where r.ResultDateTime.Month == DateTime.Now.Month && r.ResultDateTime.Year == DateTime.Now.Year
                                      group r by p.PlayerName into g
                                      orderby g.Average(s => (double)s.Score) descending
                                      select new { PlayerName = g.Key, PlayerAverage = g.Average(s => (double)s.Score) };



                List<Score> scoreList = new List<Score>();
                //Put each result into the score list
                foreach (var item in filteredResults)
                {
                    Score singleScore = new Score()
                    {
                        PlayerName = item.PlayerName,
                        AverageScore = item.PlayerAverage
                    };
                    scoreList.Add(singleScore);
                }

                //Make a view model to pass to the view
                ScoreViewModel allScores = new ScoreViewModel(scoreList);
                allScores.RoundAverages();

                return View(allScores);
            }
            else        //User isnt  logged in
            {
                return RedirectToAction("Index", "Login");
            }            
        }
    }
}