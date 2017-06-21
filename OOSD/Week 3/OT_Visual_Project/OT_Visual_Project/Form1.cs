using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OT_Visual_Project
{
    public partial class Form1 : Form
    {
        AppManager appManager;
        SphereManager sphereManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting up the panel and control panels
            StimulusPanel.Location = new Point(0, 0);
            int screenWidth = this.Width;
            StimulusPanel.Width = screenWidth;
            int screenHeight = this.Height;
            int panelHeight = (screenHeight / 100) * 75;
            StimulusPanel.Height = panelHeight;
            ControlPanel.Location = new Point(0, panelHeight);
            int controlPanelHeight = screenHeight - panelHeight;
            ControlPanel.Height = controlPanelHeight;
            ControlPanel.Width = screenWidth;

            //setting up stimulus start button position
            int buttonYPos = ControlPanel.Height - 180;
            btnStart.Location = new Point(10, buttonYPos);

            //setting up stimulus stop button position
            btnStop.Location = new Point(170, buttonYPos);
            btnStop.Enabled = false;

            //setting up stimulus results buttons
            int cPanelBottom = ControlPanel.Height - 120;
            btnCorrectClicks.Location = new Point(10, cPanelBottom);
            btnMissedClicks.Location = new Point(170, cPanelBottom);

            //Setting up Ball Tracking Buttons
            int ballBtnXPos = screenWidth - 180;
            int ballStartBtnYPos = buttonYPos;
            int ballStopBtnYPos = cPanelBottom;
            btnStartBallTracking.Location = new Point(ballBtnXPos, ballStartBtnYPos);
            btnStopBallTracking.Location = new Point(ballBtnXPos, ballStopBtnYPos);
            btnStopBallTracking.Enabled = false;

            //Initilise AppManager
            Point widthHeight = new Point(screenWidth, panelHeight);
            appManager = new AppManager(widthHeight, StimulusPanel);

            //Initilise SphereManager
            sphereManager = new SphereManager(widthHeight, StimulusPanel);
            
        }

        //Stimulus location buttons
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Call AppManager startStimulus
            appManager.startStimulus();
            tmrStimulus.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnCorrectClicks.Enabled = false;
            btnMissedClicks.Enabled = false;
            btnStartBallTracking.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrStimulus.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnCorrectClicks.Enabled = true;
            btnMissedClicks.Enabled = true;
            btnStartBallTracking.Enabled = true;
            appManager.writeResultsToCSV();
        }

        //Visual Results after stimulus buttons
        private void btnCorrectClicks_Click(object sender, EventArgs e)     //Additional feature
        {
            appManager.displayCorrectClicks();
        }

        private void btnMissedClicks_Click(object sender, EventArgs e)      //Additional feature
        {
            appManager.displayMissedClicks();
        }

        //Ball Tracking Buttons
        private void btnStartBallTracking_Click(object sender, EventArgs e)
        {
            btnStartBallTracking.Enabled = false;
            btnStopBallTracking.Enabled = true;
            btnStart.Enabled = false;
            sphereManager.startStimulus();
            tmrBallTracker.Enabled = true;
        }

        private void btnStopBallTracking_Click(object sender, EventArgs e)
        {
            btnStartBallTracking.Enabled = true;
            btnStopBallTracking.Enabled = false;
            btnStart.Enabled = true;
            tmrBallTracker.Enabled = false;
            sphereManager.writeResultsToCSV();
        }

        //Checks for mouse clicks for both stimulus and ball functions
        private void StimulusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //Capture and pass that the user has clicked
            if (tmrStimulus.Enabled)
            {
                appManager.registerClick();
            }
            if (tmrBallTracker.Enabled)
            {
                sphereManager.registerClick();
                SystemSounds.Beep.Play();
            }
        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //Capture and pass that the user has clicked
            if(tmrStimulus.Enabled)
            {
                appManager.registerClick();
            }
            if(tmrBallTracker.Enabled)
            {
                sphereManager.registerClick();
                SystemSounds.Exclamation.Play();
            }
            
        }

        //Timer 1 controls the stimulus
        private void timer1_Tick(object sender, EventArgs e)
        {
            appManager.runStimulus();
        }       

        //tmrBallTracker controls the ball tracker
        private void tmrBallTracker_Tick(object sender, EventArgs e)
        {
            sphereManager.runStimulus();
        }
    }
}
