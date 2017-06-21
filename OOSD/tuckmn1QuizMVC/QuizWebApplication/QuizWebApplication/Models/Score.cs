using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizWebApplication.Models
{
    public class Score
    {
        public string PlayerName { get; set; }
        public double AverageScore { get; set; }

        public Score()
        {

        }

        public Score(int playerId, string playerName, int totalScore, DateTime quizCompleted)
        {
            this.PlayerName = playerName;
            this.AverageScore = totalScore;
        }

        public void RoundAverage()
        {
            AverageScore = Math.Round(AverageScore, 2);
        }
    }
}