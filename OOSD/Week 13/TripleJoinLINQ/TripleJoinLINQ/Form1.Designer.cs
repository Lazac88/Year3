namespace TripleJoinLINQ
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
            this.btnFindCities = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFindCities
            // 
            this.btnFindCities.Location = new System.Drawing.Point(13, 25);
            this.btnFindCities.Name = "btnFindCities";
            this.btnFindCities.Size = new System.Drawing.Size(149, 58);
            this.btnFindCities.TabIndex = 0;
            this.btnFindCities.Text = "Find Cities";
            this.btnFindCities.UseVisualStyleBackColor = true;
            this.btnFindCities.Click += new System.EventHandler(this.btnFindCities_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(13, 117);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(149, 20);
            this.txtBoxInput.TabIndex = 1;
            // 
            // lBoxOutput
            // 
            this.lBoxOutput.FormattingEnabled = true;
            this.lBoxOutput.Location = new System.Drawing.Point(191, 25);
            this.lBoxOutput.Name = "lBoxOutput";
            this.lBoxOutput.Size = new System.Drawing.Size(334, 225);
            this.lBoxOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.lBoxOutput);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.btnFindCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindCities;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.ListBox lBoxOutput;
    }
}

