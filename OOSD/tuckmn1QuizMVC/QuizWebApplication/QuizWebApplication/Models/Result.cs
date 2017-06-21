using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizWebApplication.Models
{
    public class Result
    {
        public string QuestionNumber { get; set; }
        public string Feedback { get; set; }

        public string PlayerAnswer { get; set; }
        public string ActualAnswer { get; set; }

        public Result()
        {

        }
    }
}