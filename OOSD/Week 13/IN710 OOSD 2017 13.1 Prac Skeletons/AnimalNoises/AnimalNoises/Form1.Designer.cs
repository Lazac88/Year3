namespace AnimalNoises
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
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnWhatIsIt = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(141, 61);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(125, 54);
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnWhatIsIt
            // 
            this.btnWhatIsIt.Location = new System.Drawing.Point(141, 170);
            this.btnWhatIsIt.Name = "btnWhatIsIt";
            this.btnWhatIsIt.Size = new System.Drawing.Size(125, 54);
            this.btnWhatIsIt.TabIndex = 1;
            this.btnWhatIsIt.Text = "What Is It?";
            this.btnWhatIsIt.UseVisualStyleBackColor = true;
            this.btnWhatIsIt.Click += new System.EventHandler(this.btnWhatIsIt_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(141, 273);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(125, 54);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 395);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.btnWhatIsIt);
            this.Controls.Add(this.btnSpeak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Animal Noises";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnWhatIsIt;
        private System.Windows.Forms.Button Stop;
    }
}

