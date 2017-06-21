using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GameComputer gameComputer;
        private BusinessComputer businessComputer;
        private MultimediaComputer multimediaComputer;
        private HomeComputer homeComputer;

        private void Form1_Load(object sender, EventArgs e)
        {
            gameComputer = new GameComputer(displayBox);
            businessComputer = new BusinessComputer(displayBox);
            multimediaComputer = new MultimediaComputer(displayBox);
            homeComputer = new HomeComputer(displayBox);
        }        

        private void btnPrintSpec_Click(object sender, EventArgs e)
        {
            displayBox.Items.Clear();
            if(rBtnGame.Checked == true)
            {
                gameComputer.displaySpecs();
            }
            else if(rBtnBusiness.Checked == true)
            {
                businessComputer.displaySpecs();
            }
            else if(rBtnMultimedia.Checked == true)
            {
                multimediaComputer.displaySpecs();
            }
            else if (rBtnHome.Checked == true)
            {
                homeComputer.displaySpecs();
            }
        }
    }
}
