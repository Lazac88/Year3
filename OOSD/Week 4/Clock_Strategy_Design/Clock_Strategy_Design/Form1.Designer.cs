namespace Clock_Strategy_Design
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
            this.analogClock = new AnalogClockControl.AnalogClock();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAnalouge = new System.Windows.Forms.RadioButton();
            this.radioButtonDigital = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDigitalClock = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock
            // 
            this.analogClock.Draw1MinuteTicks = true;
            this.analogClock.Draw5MinuteTicks = true;
            this.analogClock.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock.Location = new System.Drawing.Point(155, 261);
            this.analogClock.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock.Name = "analogClock";
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(219, 219);
            this.analogClock.TabIndex = 0;
            this.analogClock.TicksColor = System.Drawing.Color.Black;
            this.analogClock.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(13, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(210, 81);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Clock";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(13, 145);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(210, 81);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Clock";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAnalouge);
            this.groupBox1.Controls.Add(this.radioButtonDigital);
            this.groupBox1.Location = new System.Drawing.Point(277, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonAnalouge
            // 
            this.radioButtonAnalouge.AutoSize = true;
            this.radioButtonAnalouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnalouge.Location = new System.Drawing.Point(27, 124);
            this.radioButtonAnalouge.Name = "radioButtonAnalouge";
            this.radioButtonAnalouge.Size = new System.Drawing.Size(118, 28);
            this.radioButtonAnalouge.TabIndex = 1;
            this.radioButtonAnalouge.TabStop = true;
            this.radioButtonAnalouge.Text = "Analouge";
            this.radioButtonAnalouge.UseVisualStyleBackColor = true;
            this.radioButtonAnalouge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonAnalouge_MouseClick);
            // 
            // radioButtonDigital
            // 
            this.radioButtonDigital.AutoSize = true;
            this.radioButtonDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDigital.Location = new System.Drawing.Point(27, 45);
            this.radioButtonDigital.Name = "radioButtonDigital";
            this.radioButtonDigital.Size = new System.Drawing.Size(85, 28);
            this.radioButtonDigital.TabIndex = 0;
            this.radioButtonDigital.TabStop = true;
            this.radioButtonDigital.Text = "Digital";
            this.radioButtonDigital.UseVisualStyleBackColor = true;
            this.radioButtonDigital.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioButtonDigital_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDigitalClock
            // 
            this.lblDigitalClock.AutoSize = true;
            this.lblDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalClock.Location = new System.Drawing.Point(191, 350);
            this.lblDigitalClock.Name = "lblDigitalClock";
            this.lblDigitalClock.Size = new System.Drawing.Size(151, 37);
            this.lblDigitalClock.TabIndex = 4;
            this.lblDigitalClock.Text = "00:00:00";
            this.lblDigitalClock.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 492);
            this.Controls.Add(this.lblDigitalClock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.analogClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAnalouge;
        private System.Windows.Forms.RadioButton radioButtonDigital;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDigitalClock;
    }
}

