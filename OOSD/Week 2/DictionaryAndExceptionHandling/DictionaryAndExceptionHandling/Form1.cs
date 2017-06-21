using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryAndExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MovieManager movieManager;
        UserInterface userInterface;

        private void Form1_Load(object sender, EventArgs e)
        {
            movieManager = new MovieManager(listBoxDisplay);
            userInterface = new UserInterface(movieManager, txtYearInput, txtTitleInput, txtDirectorInput, txtYearDelete, txtYearSearch, listBoxDisplay);
        }

        //Add Movie Button
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            userInterface.AddMovie();
        }


        //Delete Movie Button
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            userInterface.DeleteMovie();
        }

        //Search Movie Button
        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            userInterface.SearchMovie();
        }

        //Display All Movies Button
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            userInterface.DisplayAllMovies();
        }
    }
}
