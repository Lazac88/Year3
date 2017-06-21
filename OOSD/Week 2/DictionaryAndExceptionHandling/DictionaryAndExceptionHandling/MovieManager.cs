using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryAndExceptionHandling
{
    class MovieManager
    {
        SortedDictionary<int, Movie> movieDatabase = new SortedDictionary<int, Movie>();
        //ListBox listBoxDisplay;

        public MovieManager(ListBox listBoxDisplay)
        {
            //this.listBoxDisplay = listBoxDisplay;
            resetDatabase();
        }

        //takes database back to original content. Could add a rest button in the future.
        public void resetDatabase()
        {
            movieDatabase.Clear();
            Movie m1 = new Movie(1961, "West Side Story", "Jerome Robbins");
            movieDatabase.Add(1961, m1);
            Movie m2 = new Movie(1972, "The Godfather", "Francis Ford Copploa");
            movieDatabase.Add(1972, m2);
            Movie m3 = new Movie(1994, "Amadeus", "Milo Forman");
            movieDatabase.Add(1994, m3);
            Movie m4 = new Movie(2007, "No Country for Old Men", "Ethan and Joel Coen");
            movieDatabase.Add(2007, m4);
        }

        //adds a movie to the dictionary
        public void addMovie(int year, String title, String director)
        {
            Movie newMovie = new Movie(year, title, director);
            movieDatabase.Add(year, newMovie);
        }


        //removes a movie from the dictionary
        public void removeMovie(int year)
        {
            movieDatabase.Remove(year);         
        }


        //finds and returns a specific movie
        public Movie findMovie(int year)
        {
            if (movieDatabase.ContainsKey(year))
            {
                return movieDatabase[year];
            }
            else
            {
                return null;
            }
        }


        //Returns a list of all movies in the dictionary
        public List<Movie> allMovies()
        {
            List<Movie> myMovies = new List<Movie>();
            foreach(KeyValuePair<int, Movie> entry in movieDatabase)
            {
                myMovies.Add(entry.Value);
            }
            return myMovies;
        }
    }
}
