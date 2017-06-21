namespace DelegateInClass
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
            this.grpBoxRadioBtns = new System.Windows.Forms.GroupBox();
            this.rBtnSpin = new System.Windows.Forms.RadioButton();
            this.rBtnProgress = new System.Windows.Forms.RadioButton();
            this.rBtnTrack = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.grpBoxRadioBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxRadioBtns
            // 
            this.grpBoxRadioBtns.Controls.Add(this.rBtnTrack);
            this.grpBoxRadioBtns.Controls.Add(this.rBtnProgress);
            this.grpBoxRadioBtns.Controls.Add(this.rBtnSpin);
            this.grpBoxRadioBtns.Location = new System.Drawing.Point(13, 48);
            this.grpBoxRadioBtns.Name = "grpBoxRadioBtns";
            this.grpBoxRadioBtns.Size = new System.Drawing.Size(148, 229);
            this.grpBoxRadioBtns.TabIndex = 0;
            this.grpBoxRadioBtns.TabStop = false;
            this.grpBoxRadioBtns.Text = "Please Select";
            // 
            // rBtnSpin
            // 
            this.rBtnSpin.AutoSize = true;
            this.rBtnSpin.Location = new System.Drawing.Point(7, 56);
            this.rBtnSpin.Name = "rBtnSpin";
            this.rBtnSpin.Size = new System.Drawing.Size(67, 17);
            this.rBtnSpin.TabIndex = 0;
            this.rBtnSpin.TabStop = true;
            this.rBtnSpin.Text = "Spin Box";
            this.rBtnSpin.UseVisualStyleBackColor = true;
            // 
            // rBtnProgress
            // 
            this.rBtnProgress.AutoSize = true;
            this.rBtnProgress.Location = new System.Drawing.Point(7, 113);
            this.rBtnProgress.Name = "rBtnProgress";
            this.rBtnProgress.Size = new System.Drawing.Size(85, 17);
            this.rBtnProgress.TabIndex = 1;
            this.rBtnProgress.TabStop = true;
            this.rBtnProgress.Text = "Progress Bar";
            this.rBtnProgress.UseVisualStyleBackColor = true;
            // 
            // rBtnTrack
            // 
            this.rBtnTrack.AutoSize = true;
            this.rBtnTrack.Location = new System.Drawing.Point(7, 171);
            this.rBtnTrack.Name = "rBtnTrack";
            this.rBtnTrack.Size = new System.Drawing.Size(72, 17);
            this.rBtnTrack.TabIndex = 2;
            this.rBtnTrack.TabStop = true;
            this.rBtnTrack.Text = "Track Bar";
            this.rBtnTrack.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(20, 333);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 72);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Slow Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(299, 104);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(463, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(299, 161);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(299, 219);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(463, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 467);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpBoxRadioBtns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxRadioBtns.ResumeLayout(false);
            this.grpBoxRadioBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRadioBtns;
        private System.Windows.Forms.RadioButton rBtnTrack;
        private System.Windows.Forms.RadioButton rBtnProgress;
        private System.Windows.Forms.RadioButton rBtnSpin;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

