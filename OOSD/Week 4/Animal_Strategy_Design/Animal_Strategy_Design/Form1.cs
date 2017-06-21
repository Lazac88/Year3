using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Strategy_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        CritterCatalogue critCat;
        RadioButton myBtnChecked;
        List<Critter> critterList;
        AnimalManager animalManager;

        private void Form1_Load(object sender, EventArgs e)
        {
            critCat = new CritterCatalogue("animalList.txt");
            critterList = new List<Critter>();
            animalManager = new AnimalManager();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            critterList = critCat.CritterQuery(myBtnChecked.Text);
            if(critterList.Count < 5)
            {
                animalManager.myDisplay = new DisplayFew();
            }
            else
            {
                animalManager.myDisplay = new DisplayMany();
            }
        }

        private void rBtnCat_MouseDown(object sender, MouseEventArgs e)
        {
            myBtnChecked = rBtnCat;
        }

        private void rBtnDog_MouseDown(object sender, MouseEventArgs e)
        {
            myBtnChecked = rBtnDog;
        }

        private void rBtnDuck_MouseDown(object sender, MouseEventArgs e)
        {
            myBtnChecked = rBtnDuck;
        }

        private void rBtnRabbit_MouseDown(object sender, MouseEventArgs e)
        {
            myBtnChecked = rBtnRabbit;
        }
    }
}
