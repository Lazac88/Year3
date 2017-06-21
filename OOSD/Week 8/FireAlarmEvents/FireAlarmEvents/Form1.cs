using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarmEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FireAlarmSubject subject;
        AlarmObserver aObs;
        InstructionsObserver iObs;

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new FireAlarmSubject();
            iObs = new InstructionsObserver(subject);
            aObs = new AlarmObserver(subject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EFireCategory userChoice;

            if(rBtnMinor.Checked)
            {
                userChoice = EFireCategory.MINOR;
            }
            else if(rBtnSerious.Checked)
            {
                userChoice = EFireCategory.SERIOUS;
            }
            else
            {
                userChoice = EFireCategory.INFERNO;
            }

            subject.OnFireEvent(userChoice);
        }
    }
}
