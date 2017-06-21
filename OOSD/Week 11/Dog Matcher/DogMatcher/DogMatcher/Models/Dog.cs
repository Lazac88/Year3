using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DogMatcher.Models
{
    public class Dog
    {
        public string BreedName { get; set; }
        public string DisplayName { get; set; }
        public string ImageName { get; set; }
        public EScale ActivityLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        [Display(Name = "Good With Children?  ")]
        public bool GoodWithChildren { get; set; }
        [Display(Name = "Slobbers?  ")]
        public bool Drools { get; set; }
        public ELength Coatlength { get; set; }
        public ESize Size { get; set; }

        public int score { get; set; }

        public Dog()
        {
            score = 0;
        }

        public void ResetScore()
        {
            score = 0;
        }
    }
}