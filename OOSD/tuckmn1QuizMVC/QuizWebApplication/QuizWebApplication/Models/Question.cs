using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizWebApplication.Models
{
    public enum EQuestionType { Multi, TrueFalse, Error }
    public class Question
    {
        private const int SHUFFLE_TIMES = 10;
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        public List<string> AllAnswers { get; set; }
        public EQuestionType qType { get; set; }
        private Random rand;

        public Question()
        {
            rand = new Random();
        }

        public Question(string Category, string Difficulty, string QuestionText, string Answer, List<string> AllAnswers, EQuestionType qType)
        {
            this.Category = Category;
            this.Difficulty = Difficulty;
            this.QuestionText = QuestionText;
            this.Answer = Answer;
            this.AllAnswers = AllAnswers;
            this.qType = qType;
            rand = new Random();
        }

        public void ShuffleAnswers()
        {
            int size = AllAnswers.Count;
            for(int i = 0; i < SHUFFLE_TIMES; i++)
            {
                int first = rand.Next(size);
                int second = rand.Next(size);

                //Swap the array around
                string temp = AllAnswers[first];
                AllAnswers[first] = AllAnswers[second];
                AllAnswers[second] = temp;
            }
        }

        public void OrderTrueFalse()
        {
            List<string> orderedList = new List<string>();
            orderedList.Add("True");
            orderedList.Add("False");
            AllAnswers = orderedList;
        }
    }
}