using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryAndExceptionHandling
{
    class UserInterface
    {
        //Class designed to handle all front end input and output

        const int MIN_MOVIE_YEAR = 1900;
        const int FUTURE_MOVIE_YEAR = 5;    //Const for how many years past the current year we will accept input for

        const int MIN_INPUT_STRING = 1;
        const int MAX_INPUT_STRING = 50;

        TextBox addYear;
        TextBox addTitle;
        TextBox addDirector;
        TextBox removeYear;
        TextBox findYear;
        ListBox userDisplay;
        MovieManager movieManager;

        public UserInterface(MovieManager movieManager, TextBox addYear, TextBox addTitle, TextBox addDirector, TextBox removeYear, TextBox findYear, ListBox userDisplay)
        {
            this.movieManager = movieManager;
            this.addYear = addYear;
            this.addTitle = addTitle;
            this.addDirector = addDirector;
            this.removeYear = removeYear;
            this.findYear = findYear;
            this.userDisplay = userDisplay;
        }

        //Adds new movie to the database if not already there
        public void AddMovie()
        {
            String yearText = addYear.Text;            
            String title = addTitle.Text;
            String director = addDirector.Text;
            if (checkValidYear(yearText) && checkStringLength(title) && checkStringLength(director)) //checks all inputs are valid and within required parameters
            {
                int year = Convert.ToInt32(yearText);
                if(movieManager.findMovie(year) == null)        //checks that there in no movie for that year already in the database.
                {
                    movieManager.addMovie(year, title, director);
                    userDisplay.Items.Add("Movie Added Successfully");
                    addYear.Clear();                                                //clear all text fields only when a movie has submitted successfully
                    addTitle.Clear();
                    addDirector.Clear();
                }
                else
                {
                    userDisplay.Items.Add("There is already a movie from this year");       //Feedback for the user if there is already a movie
                }
            }
        }

        //Removes a single movie based on year
        public void DeleteMovie()
        {
            String yearText = removeYear.Text;            
            if(checkValidYear(yearText))                //check year input is valid
            {
                int year = Convert.ToInt32(yearText);
                if(movieManager.findMovie(year) != null)        //checks that there is a movie from the specified year
                {
                    removeYear.Clear();
                    movieManager.removeMovie(year);
                    userDisplay.Items.Add("Movie from year " + yearText + " Deleted");      //Confirmation
                }
                else
                {
                    userDisplay.Items.Add("Movie from year " + yearText + " not found");    //Feedback for user if movie not found
                }                
            }
        }

        //Searches for and displays information about a movie based on its year
        public void SearchMovie()
        {
            String yearText = findYear.Text;
            if (checkValidYear(yearText))           //Check year input is valid
            {
                int year = Convert.ToInt32(yearText);
                Movie myMovie = movieManager.findMovie(year);
                if(myMovie != null)                 //Checks movie is in database
                {
                    findYear.Clear();
                    userDisplay.Items.Add(myMovie.ToString());
                }
                else
                {
                    userDisplay.Items.Add("No movie was found for this year");  //Feedback if movie doesn't exist
                }
            }
        }

        //Grabs all movies as a list from database and displays them in the listbox
        public void DisplayAllMovies()
        {
            List<Movie> allMovies = movieManager.allMovies();
            foreach(Movie m in allMovies)
            {
                userDisplay.Items.Add(m.ToString());
            }
        }

        //Method to check that year input is an integer and between specified values
        //Returns a Boolean true if the year is acceptable
        public Boolean checkValidYear(String yearText)
        {
            String inputError = "";
            Boolean noError = true;
            int year = 1;
            try                 //try catch to check that the inputted year can be converted to an int
            {
                year = Convert.ToInt32(yearText);
            }
            catch (FormatException)
            {
                noError = false;
                inputError = "Year input incorrect";        //Feedback on year issue
                userDisplay.Items.Add(inputError);
            }
            catch(OverflowException)
            {
                noError = false;
                inputError = "Year invalid";        //Feedback on year issue
                userDisplay.Items.Add(inputError);
            }
            if (noError)
            {
                int currentYear = DateTime.Now.Year;
                if (year < MIN_MOVIE_YEAR || year > (currentYear + FUTURE_MOVIE_YEAR))      //Checks that the inputted year falls within specified range
                {
                    noError = false;
                    inputError = "Not a valid year";        //Feedback on year issue
                    userDisplay.Items.Add(inputError);
                }
            }

            return noError;
        }

        //Checks the length of any inputted strings. Stops strings of zero characters, and strings with far too many characters
        //Returns a Boolean true if the inputted string is acceptable
        public Boolean checkStringLength(String input)
        {
            if(input.Length >= MIN_INPUT_STRING && input.Length <= MAX_INPUT_STRING)
            {
                return true;
            }
            else
            {
                userDisplay.Items.Add("Please sure the text fieldshave at least 1 character and are below 50 characters");       //Feedback on text issue
                return false;
            }
        }
    }
}
