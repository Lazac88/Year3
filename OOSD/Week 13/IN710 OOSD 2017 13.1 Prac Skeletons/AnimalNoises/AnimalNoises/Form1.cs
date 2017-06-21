using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalNoises
{
    public partial class Form1 : Form
    {
        Animal mainAnimal;
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();
            
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            t1 = new Thread(mainAnimal.speak);
            t1.Start();            
        }

        private void btnWhatIsIt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog....");
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            t1.Abort();
        }
    }
}
