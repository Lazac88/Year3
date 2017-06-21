namespace OT_Visual_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StimulusPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.btnStopBallTracking = new System.Windows.Forms.Button();
            this.btnStartBallTracking = new System.Windows.Forms.Button();
            this.btnMissedClicks = new System.Windows.Forms.Button();
            this.btnCorrectClicks = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrStimulus = new System.Windows.Forms.Timer(this.components);
            this.tmrBallTracker = new System.Windows.Forms.Timer(this.components);
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StimulusPanel
            // 
            this.StimulusPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StimulusPanel.BackColor = System.Drawing.Color.Black;
            this.StimulusPanel.Location = new System.Drawing.Point(0, 35);
            this.StimulusPanel.Name = "StimulusPanel";
            this.StimulusPanel.Size = new System.Drawing.Size(712, 307);
            this.StimulusPanel.TabIndex = 0;
            this.StimulusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StimulusPanel_MouseDown);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.Silver;
            this.ControlPanel.Controls.Add(this.btnStopBallTracking);
            this.ControlPanel.Controls.Add(this.btnStartBallTracking);
            this.ControlPanel.Controls.Add(this.btnMissedClicks);
            this.ControlPanel.Controls.Add(this.btnCorrectClicks);
            this.ControlPanel.Controls.Add(this.btnStop);
            this.ControlPanel.Controls.Add(this.btnStart);
            this.ControlPanel.Location = new System.Drawing.Point(0, 314);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(712, 194);
            this.ControlPanel.TabIndex = 1;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            // 
            // btnStopBallTracking
            // 
            this.btnStopBallTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopBallTracking.Location = new System.Drawing.Point(550, 131);
            this.btnStopBallTracking.Name = "btnStopBallTracking";
            this.btnStopBallTracking.Size = new System.Drawing.Size(150, 60);
            this.btnStopBallTracking.TabIndex = 6;
            this.btnStopBallTracking.Text = "Stop Ball Tracking";
            this.btnStopBallTracking.UseVisualStyleBackColor = true;
            this.btnStopBallTracking.Click += new System.EventHandler(this.btnStopBallTracking_Click);
            // 
            // btnStartBallTracking
            // 
            this.btnStartBallTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBallTracking.Location = new System.Drawing.Point(550, 55);
            this.btnStartBallTracking.Name = "btnStartBallTracking";
            this.btnStartBallTracking.Size = new System.Drawing.Size(150, 60);
            this.btnStartBallTracking.TabIndex = 5;
            this.btnStartBallTracking.Text = "Start Ball Tracking";
            this.btnStartBallTracking.UseVisualStyleBackColor = true;
            this.btnStartBallTracking.Click += new System.EventHandler(this.btnStartBallTracking_Click);
            // 
            // btnMissedClicks
            // 
            this.btnMissedClicks.Enabled = false;
            this.btnMissedClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMissedClicks.Location = new System.Drawing.Point(46, 131);
            this.btnMissedClicks.Name = "btnMissedClicks";
            this.btnMissedClicks.Size = new System.Drawing.Size(150, 60);
            this.btnMissedClicks.TabIndex = 4;
            this.btnMissedClicks.Text = "Show Missed Clicks";
            this.btnMissedClicks.UseVisualStyleBackColor = true;
            this.btnMissedClicks.Click += new System.EventHandler(this.btnMissedClicks_Click);
            // 
            // btnCorrectClicks
            // 
            this.btnCorrectClicks.Enabled = false;
            this.btnCorrectClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectClicks.Location = new System.Drawing.Point(46, 46);
            this.btnCorrectClicks.Name = "btnCorrectClicks";
            this.btnCorrectClicks.Size = new System.Drawing.Size(150, 60);
            this.btnCorrectClicks.TabIndex = 3;
            this.btnCorrectClicks.Text = "Show Correct Clicks";
            this.btnCorrectClicks.UseVisualStyleBackColor = true;
            this.btnCorrectClicks.Click += new System.EventHandler(this.btnCorrectClicks_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(202, 131);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 60);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(202, 46);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrStimulus
            // 
            this.tmrStimulus.Interval = 1500;
            this.tmrStimulus.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrBallTracker
            // 
            this.tmrBallTracker.Interval = 20;
            this.tmrBallTracker.Tick += new System.EventHandler(this.tmrBallTracker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 520);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.StimulusPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StimulusPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrStimulus;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnMissedClicks;
        private System.Windows.Forms.Button btnCorrectClicks;
        private System.Windows.Forms.Button btnStopBallTracking;
        private System.Windows.Forms.Button btnStartBallTracking;
        private System.Windows.Forms.Timer tmrBallTracker;
    }
}

