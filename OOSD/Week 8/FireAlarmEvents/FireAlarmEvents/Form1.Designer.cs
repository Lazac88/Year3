namespace FireAlarmEvents
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
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxAlarmLvls = new System.Windows.Forms.GroupBox();
            this.rBtnInferno = new System.Windows.Forms.RadioButton();
            this.rBtnSerious = new System.Windows.Forms.RadioButton();
            this.rBtnMinor = new System.Windows.Forms.RadioButton();
            this.grpBoxAlarmLvls.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fire Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBoxAlarmLvls
            // 
            this.grpBoxAlarmLvls.Controls.Add(this.rBtnInferno);
            this.grpBoxAlarmLvls.Controls.Add(this.rBtnSerious);
            this.grpBoxAlarmLvls.Controls.Add(this.rBtnMinor);
            this.grpBoxAlarmLvls.Location = new System.Drawing.Point(13, 100);
            this.grpBoxAlarmLvls.Name = "grpBoxAlarmLvls";
            this.grpBoxAlarmLvls.Size = new System.Drawing.Size(151, 183);
            this.grpBoxAlarmLvls.TabIndex = 1;
            this.grpBoxAlarmLvls.TabStop = false;
            this.grpBoxAlarmLvls.Text = "Alarm Levels";
            // 
            // rBtnInferno
            // 
            this.rBtnInferno.AutoSize = true;
            this.rBtnInferno.Location = new System.Drawing.Point(6, 100);
            this.rBtnInferno.Name = "rBtnInferno";
            this.rBtnInferno.Size = new System.Drawing.Size(58, 17);
            this.rBtnInferno.TabIndex = 2;
            this.rBtnInferno.TabStop = true;
            this.rBtnInferno.Text = "Inferno";
            this.rBtnInferno.UseVisualStyleBackColor = true;
            // 
            // rBtnSerious
            // 
            this.rBtnSerious.AutoSize = true;
            this.rBtnSerious.Location = new System.Drawing.Point(6, 66);
            this.rBtnSerious.Name = "rBtnSerious";
            this.rBtnSerious.Size = new System.Drawing.Size(60, 17);
            this.rBtnSerious.TabIndex = 1;
            this.rBtnSerious.TabStop = true;
            this.rBtnSerious.Text = "Serious";
            this.rBtnSerious.UseVisualStyleBackColor = true;
            // 
            // rBtnMinor
            // 
            this.rBtnMinor.AutoSize = true;
            this.rBtnMinor.Checked = true;
            this.rBtnMinor.Location = new System.Drawing.Point(7, 32);
            this.rBtnMinor.Name = "rBtnMinor";
            this.rBtnMinor.Size = new System.Drawing.Size(51, 17);
            this.rBtnMinor.TabIndex = 0;
            this.rBtnMinor.TabStop = true;
            this.rBtnMinor.Text = "Minor";
            this.rBtnMinor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 295);
            this.Controls.Add(this.grpBoxAlarmLvls);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxAlarmLvls.ResumeLayout(false);
            this.grpBoxAlarmLvls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpBoxAlarmLvls;
        private System.Windows.Forms.RadioButton rBtnInferno;
        private System.Windows.Forms.RadioButton rBtnSerious;
        private System.Windows.Forms.RadioButton rBtnMinor;
    }
}

