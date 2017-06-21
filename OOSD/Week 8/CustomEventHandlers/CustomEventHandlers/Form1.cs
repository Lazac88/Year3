using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomEventHandlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ButtonObserver obs1;
        ButtonObserver obs2;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the forms event handler");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obs1 = new ButtonObserver(button1, 33);
            obs2 = new ButtonObserver(button1, 15);
        }
    }
}
