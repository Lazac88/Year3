using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public partial class Form1 : Form
    {
        private const int NUM_ANIMALS_PER_CONTINENT = 4;
        public Form1()
        {
            InitializeComponent();
        }

        Graphics canvas;
        Random rand;
        NorthAmerica northAmerica;
        Australia australia;
        NewZealand newzealand;

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            canvas = CreateGraphics();
            northAmerica = new NorthAmerica(listBoxAnimalDetails, rand, NUM_ANIMALS_PER_CONTINENT, canvas);
            australia = new Australia(listBoxAnimalDetails, rand, NUM_ANIMALS_PER_CONTINENT, canvas);
            newzealand = new NewZealand(listBoxAnimalDetails, rand, NUM_ANIMALS_PER_CONTINENT, canvas);
        }

        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {
            northAmerica.runSimulation();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            australia.runSimulation();
        }

        private void btnNewZealand_Click(object sender, EventArgs e)
        {
            newzealand.runSimulation();
        }
    }
}
