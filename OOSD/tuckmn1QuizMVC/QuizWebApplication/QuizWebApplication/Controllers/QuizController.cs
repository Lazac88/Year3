using Newtonsoft.Json.Linq;
using QuizWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace QuizWebApplication.Controllers
{
    public class QuizController : Controller
    {
        private PlayerResultDbDataContext db;

        public QuizController()
        {
            db = new PlayerResultDbDataContext();
        }
        public ActionResult Index()
        {
            //Check User Is Logged In
            if(CheckLoggedIn())
            {
                User currentUser = new User()
                {
                    Name = (string)Session["name"]
                };
                return View(currentUser);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }        
        }

        //Forgets user from Session and directs them back to login page
        public ActionResult Logout()
        {
            Session["name"] = null;
            return RedirectToAction("Index", "Login");
        }

        //Simple function to check session for user login
        public bool CheckLoggedIn()
        {
            bool loggedIn = false;
            if (Session["name"] != null)
            {
                loggedIn = true;
            }
            return loggedIn;
        }

        public ActionResult StartQuiz()
        {
            //Check User Is Logged In
            if (CheckLoggedIn())
            {
                //Set up Session with pre-quiz values
                Session["questionCount"] = 1;
                Session["score"] = 0;

                //Get a question from the trivia API
                Question currentQuestion = GetQuestion();

                //Save answer to session
                Session["answer"] = currentQuestion.Answer;

                //Create Result class
                Result currentResult = new Result();
                currentResult.QuestionNumber = Session["questionCount"].ToString();
                //Set up tuple (multiple view models) to pass to the view
                var test = new Tuple<Question, Result>(currentQuestion, currentResult);
                return View("QuestionPage", test);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
                                   
        }

        //Give the user feed back at end of quiz
        public ActionResult DisplayResults()
        {
            //Check User Is Logged In
            if (CheckLoggedIn())
            {
                int finalScore = (int)Session["score"];
                string feedback = "";
                if (finalScore < 3)
                {
                    feedback = "Better Luck Next Time";
                }
                else if (finalScore < 5)
                {
                    feedback = "So So";
                }
                else if (finalScore < 7)
                {
                    feedback = "Good Effort";
                }
                else if (finalScore < 9)
                {
                    feedback = "Great Job!";
                }
                else
                {
                    feedback = "Master";
                }

                //Create view model to pass to the View
                EndResult endResult = new EndResult();
                endResult.Feedback = feedback;
                endResult.FinalScore = finalScore;
                return View(endResult);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }            
        }

        //Get next question or send to results page if finished
        public ActionResult NextQuestion()
        {
            //Check User Is Logged In
            if (CheckLoggedIn())
            {
                int questionCount = (int)Session["questionCount"];
                //If questionCount is more than 10, go to results, else next question
                if (questionCount > 10)
                {
                    //Save Results
                    SubmitResults();
                    //Go to results page
                    return RedirectToAction("DisplayResults", "Quiz");

                }
                else
                {
                    //Get new question
                    Question currentQuestion = GetQuestion();
                    Session["answer"] = currentQuestion.Answer;
                    Result currentResult = new Result();
                    currentResult.QuestionNumber = Session["questionCount"].ToString();
                    var test = new Tuple<Question, Result>(currentQuestion, currentResult);
                    return View("QuestionPage", test);
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }            
        }

        [HttpPost]
        public ActionResult ContinueQuiz(Result result)
        {
            //Check User Is Logged In
            if (CheckLoggedIn())
            {
                //Calculate if answer is correct and add to score(or not)
                string playerAnswer = result.PlayerAnswer;
                string actualAnswer = (string)Session["answer"];
                Result playerResult = new Result();
                playerResult.PlayerAnswer = playerAnswer;
                playerResult.ActualAnswer = actualAnswer;



                if (playerAnswer == actualAnswer)
                {
                    int score = (int)Session["score"];
                    score++;
                    Session["score"] = score;
                    playerResult.Feedback = "Correct!";
                }
                else
                {
                    playerResult.Feedback = "Incorrect";
                }

                //Increment questionCount
                int questionCount = (int)Session["questionCount"];
                questionCount++;
                Session["questionCount"] = questionCount;



                return View("AnswerFeedback", playerResult);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }            
        }

        //Submit results to database
        public void SubmitResults()
        {
            int playerId = (int)Session["id"];
            int score = (int)Session["score"];
            
            string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:MM:SS");
            //DateTime submissionTime = ;

            //Create result object
            tblResult result = new tblResult
            {
                PlayerID = playerId,
                Score = score,
                ResultDateTime = DateTime.Now
            };

            //Add new player to tblPlayers collection
            db.tblResults.InsertOnSubmit(result);

            //submit changes to db
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //API call to retrieve question
        public Question GetQuestion()
        {
            //Call API opentbd
            string url = "https://opentdb.com/api.php?amount=1";
            HttpClient client = new HttpClient();
            string searchResult = client.GetStringAsync(url).Result;

            JObject baseObject = JObject.Parse(searchResult);

            List<JObject> arrayOfJsonObjects = new List<JObject>();
            arrayOfJsonObjects = baseObject["results"].Select(w => (JObject)w).ToList();

            //Get info from JSON
            string Category = (string)arrayOfJsonObjects[0]["category"];
            string Difficulty = (string)arrayOfJsonObjects[0]["difficulty"];
            string QuestionText = (string)arrayOfJsonObjects[0]["question"];
            QuestionText = WebUtility.HtmlDecode(QuestionText);     //Remove encoded characters
            string Answer = (string)arrayOfJsonObjects[0]["correct_answer"];
            Answer = WebUtility.HtmlDecode(Answer);                 //Remove encoded characters
            string type = (string)arrayOfJsonObjects[0]["type"];
            List<String> IncorrectAnswers = arrayOfJsonObjects[0]["incorrect_answers"].Select(w => (string)w).ToList();
            EQuestionType Type;
            switch(type)
            {
                case "multiple":
                    Type = EQuestionType.Multi;
                    break;
                case "boolean":
                    Type = EQuestionType.TrueFalse;
                    break;
                default:
                    Type = EQuestionType.Error;
                    break;
            }

            List<String> AllAnswers = IncorrectAnswers;
            AllAnswers.Add(Answer);

            Question currentQuestion = new Question(Category, Difficulty, QuestionText, Answer, AllAnswers, Type);
            if(currentQuestion.qType == EQuestionType.Multi)
            {
                currentQuestion.ShuffleAnswers();
            }
            else
            {
                currentQuestion.OrderTrueFalse();
            }
            
            return currentQuestion;
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Login");
        }
    }
}