namespace PredicateApp
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
            this.btnRandoms = new System.Windows.Forms.Button();
            this.btnEvenNums = new System.Windows.Forms.Button();
            this.btnSmallNums = new System.Windows.Forms.Button();
            this.listBoxAll = new System.Windows.Forms.ListBox();
            this.listBoxSelection = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRandoms
            // 
            this.btnRandoms.Location = new System.Drawing.Point(65, 23);
            this.btnRandoms.Name = "btnRandoms";
            this.btnRandoms.Size = new System.Drawing.Size(206, 47);
            this.btnRandoms.TabIndex = 0;
            this.btnRandoms.Text = "Generate Randoms";
            this.btnRandoms.UseVisualStyleBackColor = true;
            this.btnRandoms.Click += new System.EventHandler(this.btnRandoms_Click);
            // 
            // btnEvenNums
            // 
            this.btnEvenNums.Location = new System.Drawing.Point(381, 23);
            this.btnEvenNums.Name = "btnEvenNums";
            this.btnEvenNums.Size = new System.Drawing.Size(206, 47);
            this.btnEvenNums.TabIndex = 1;
            this.btnEvenNums.Text = "Select Even Numbers";
            this.btnEvenNums.UseVisualStyleBackColor = true;
            this.btnEvenNums.Click += new System.EventHandler(this.btnEvenNums_Click);
            // 
            // btnSmallNums
            // 
            this.btnSmallNums.Location = new System.Drawing.Point(381, 90);
            this.btnSmallNums.Name = "btnSmallNums";
            this.btnSmallNums.Size = new System.Drawing.Size(206, 47);
            this.btnSmallNums.TabIndex = 2;
            this.btnSmallNums.Text = "Select Numbers < 10";
            this.btnSmallNums.UseVisualStyleBackColor = true;
            this.btnSmallNums.Click += new System.EventHandler(this.btnSmallNums_Click);
            // 
            // listBoxAll
            // 
            this.listBoxAll.FormattingEnabled = true;
            this.listBoxAll.Location = new System.Drawing.Point(65, 167);
            this.listBoxAll.Name = "listBoxAll";
            this.listBoxAll.Size = new System.Drawing.Size(206, 394);
            this.listBoxAll.TabIndex = 3;
            // 
            // listBoxSelection
            // 
            this.listBoxSelection.FormattingEnabled = true;
            this.listBoxSelection.Location = new System.Drawing.Point(381, 167);
            this.listBoxSelection.Name = "listBoxSelection";
            this.listBoxSelection.Size = new System.Drawing.Size(206, 394);
            this.listBoxSelection.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 597);
            this.Controls.Add(this.listBoxSelection);
            this.Controls.Add(this.listBoxAll);
            this.Controls.Add(this.btnSmallNums);
            this.Controls.Add(this.btnEvenNums);
            this.Controls.Add(this.btnRandoms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandoms;
        private System.Windows.Forms.Button btnEvenNums;
        private System.Windows.Forms.Button btnSmallNums;
        private System.Windows.Forms.ListBox listBoxAll;
        private System.Windows.Forms.ListBox listBoxSelection;
    }
}

