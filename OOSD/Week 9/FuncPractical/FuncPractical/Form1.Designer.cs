namespace FuncPractical
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
            this.btnCountrySearch = new System.Windows.Forms.Button();
            this.txtBoxCountryInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCountry = new System.Windows.Forms.ListBox();
            this.btnIncreasePop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCountrySearch
            // 
            this.btnCountrySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountrySearch.Location = new System.Drawing.Point(410, 30);
            this.btnCountrySearch.Name = "btnCountrySearch";
            this.btnCountrySearch.Size = new System.Drawing.Size(162, 53);
            this.btnCountrySearch.TabIndex = 0;
            this.btnCountrySearch.Text = "Country Search";
            this.btnCountrySearch.UseVisualStyleBackColor = true;
            this.btnCountrySearch.Click += new System.EventHandler(this.btnCountrySearch_Click);
            // 
            // txtBoxCountryInput
            // 
            this.txtBoxCountryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCountryInput.Location = new System.Drawing.Point(78, 52);
            this.txtBoxCountryInput.Name = "txtBoxCountryInput";
            this.txtBoxCountryInput.Size = new System.Drawing.Size(227, 29);
            this.txtBoxCountryInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter A Country";
            // 
            // listBoxCountry
            // 
            this.listBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCountry.FormattingEnabled = true;
            this.listBoxCountry.ItemHeight = 24;
            this.listBoxCountry.Location = new System.Drawing.Point(78, 123);
            this.listBoxCountry.Name = "listBoxCountry";
            this.listBoxCountry.Size = new System.Drawing.Size(494, 388);
            this.listBoxCountry.TabIndex = 3;
            // 
            // btnIncreasePop
            // 
            this.btnIncreasePop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreasePop.Location = new System.Drawing.Point(182, 526);
            this.btnIncreasePop.Name = "btnIncreasePop";
            this.btnIncreasePop.Size = new System.Drawing.Size(239, 52);
            this.btnIncreasePop.TabIndex = 4;
            this.btnIncreasePop.Text = "Times 3 Population";
            this.btnIncreasePop.UseVisualStyleBackColor = true;
            this.btnIncreasePop.Click += new System.EventHandler(this.btnIncreasePop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 590);
            this.Controls.Add(this.btnIncreasePop);
            this.Controls.Add(this.listBoxCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCountryInput);
            this.Controls.Add(this.btnCountrySearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountrySearch;
        private System.Windows.Forms.TextBox txtBoxCountryInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCountry;
        private System.Windows.Forms.Button btnIncreasePop;
    }
}

