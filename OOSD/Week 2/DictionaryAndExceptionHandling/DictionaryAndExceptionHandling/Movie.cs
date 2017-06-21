using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndExceptionHandling
{
    class Movie
    {

        //Gets and sets for movie data
        public int Year { get; set; }
        public String Title { get; set; }
        public String Director { get; set; }

        public Movie(int year, String title, String director)
        {
            Year = year;
            Title = title;
            Director = director;
        }

        //Prints out the movie details
        public override string ToString()
        {
            return Year.ToString() + ", " + Title + ", " + Director;
        }
    }
}
