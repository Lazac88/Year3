namespace FireLightning
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
            this.lblStrikeIntensityAvg = new System.Windows.Forms.Label();
            this.txtBoxStrikeIntensity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lBoxLargeFires = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxlatLongFile = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxFireStrikes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStrikeIntensityAvg
            // 
            this.lblStrikeIntensityAvg.AutoSize = true;
            this.lblStrikeIntensityAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrikeIntensityAvg.Location = new System.Drawing.Point(22, 40);
            this.lblStrikeIntensityAvg.Name = "lblStrikeIntensityAvg";
            this.lblStrikeIntensityAvg.Size = new System.Drawing.Size(206, 20);
            this.lblStrikeIntensityAvg.TabIndex = 0;
            this.lblStrikeIntensityAvg.Text = "Average Strike Intensity:";
            // 
            // txtBoxStrikeIntensity
            // 
            this.txtBoxStrikeIntensity.Location = new System.Drawing.Point(278, 40);
            this.txtBoxStrikeIntensity.Name = "txtBoxStrikeIntensity";
            this.txtBoxStrikeIntensity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStrikeIntensity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Three Largest Fires (by area):";
            // 
            // lBoxLargeFires
            // 
            this.lBoxLargeFires.FormattingEnabled = true;
            this.lBoxLargeFires.Location = new System.Drawing.Point(26, 126);
            this.lBoxLargeFires.Name = "lBoxLargeFires";
            this.lBoxLargeFires.Size = new System.Drawing.Size(352, 108);
            this.lBoxLargeFires.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lat, Long, and FileName:";
            // 
            // lBoxlatLongFile
            // 
            this.lBoxlatLongFile.FormattingEnabled = true;
            this.lBoxlatLongFile.Location = new System.Drawing.Point(26, 281);
            this.lBoxlatLongFile.Name = "lBoxlatLongFile";
            this.lBoxlatLongFile.Size = new System.Drawing.Size(352, 134);
            this.lBoxlatLongFile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Strikes That Caused Fires:";
            // 
            // lBoxFireStrikes
            // 
            this.lBoxFireStrikes.FormattingEnabled = true;
            this.lBoxFireStrikes.Location = new System.Drawing.Point(26, 462);
            this.lBoxFireStrikes.Name = "lBoxFireStrikes";
            this.lBoxFireStrikes.Size = new System.Drawing.Size(352, 134);
            this.lBoxFireStrikes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 608);
            this.Controls.Add(this.lBoxFireStrikes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBoxlatLongFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBoxLargeFires);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxStrikeIntensity);
            this.Controls.Add(this.lblStrikeIntensityAvg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStrikeIntensityAvg;
        private System.Windows.Forms.TextBox txtBoxStrikeIntensity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxLargeFires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxlatLongFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxFireStrikes;
    }
}

