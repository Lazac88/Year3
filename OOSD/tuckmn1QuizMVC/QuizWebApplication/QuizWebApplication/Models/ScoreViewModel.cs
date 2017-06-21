using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizWebApplication.Models
{
    public class ScoreViewModel
    {
        public List<Score> DisplayScores { get; set; }

        public ScoreViewModel() { }

        public ScoreViewModel(List<Score> scoreList)
        {
            this.DisplayScores = scoreList;
        }

        public void RoundAverages()
        {
            foreach(Score s in DisplayScores)
            {
                s.RoundAverage();
            }
        }
    }
}