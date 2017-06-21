namespace DictionaryAndExceptionHandling
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtYearInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleInput = new System.Windows.Forms.TextBox();
            this.txtDirectorInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYearDelete = new System.Windows.Forms.TextBox();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYearSearch = new System.Windows.Forms.TextBox();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(13, 35);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(93, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtYearInput
            // 
            this.txtYearInput.Location = new System.Drawing.Point(289, 38);
            this.txtYearInput.Name = "txtYearInput";
            this.txtYearInput.Size = new System.Drawing.Size(240, 20);
            this.txtYearInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year:";
            // 
            // txtTitleInput
            // 
            this.txtTitleInput.Location = new System.Drawing.Point(289, 64);
            this.txtTitleInput.Name = "txtTitleInput";
            this.txtTitleInput.Size = new System.Drawing.Size(240, 20);
            this.txtTitleInput.TabIndex = 3;
            // 
            // txtDirectorInput
            // 
            this.txtDirectorInput.Location = new System.Drawing.Point(289, 90);
            this.txtDirectorInput.Name = "txtDirectorInput";
            this.txtDirectorInput.Size = new System.Drawing.Size(240, 20);
            this.txtDirectorInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Director:";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(13, 167);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteMovie.TabIndex = 7;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year:";
            // 
            // txtYearDelete
            // 
            this.txtYearDelete.Location = new System.Drawing.Point(289, 172);
            this.txtYearDelete.Name = "txtYearDelete";
            this.txtYearDelete.Size = new System.Drawing.Size(240, 20);
            this.txtYearDelete.TabIndex = 9;
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.Location = new System.Drawing.Point(13, 245);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(93, 23);
            this.btnSearchMovie.TabIndex = 10;
            this.btnSearchMovie.Text = "Search Movie";
            this.btnSearchMovie.UseVisualStyleBackColor = true;
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Year:";
            // 
            // txtYearSearch
            // 
            this.txtYearSearch.Location = new System.Drawing.Point(289, 247);
            this.txtYearSearch.Name = "txtYearSearch";
            this.txtYearSearch.Size = new System.Drawing.Size(240, 20);
            this.txtYearSearch.TabIndex = 12;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(13, 318);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(93, 23);
            this.btnDisplayAll.TabIndex = 13;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxDisplay.Location = new System.Drawing.Point(216, 318);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(313, 225);
            this.listBoxDisplay.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 604);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.txtYearSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchMovie);
            this.Controls.Add(this.txtYearDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirectorInput);
            this.Controls.Add(this.txtTitleInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYearInput);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtYearInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleInput;
        private System.Windows.Forms.TextBox txtDirectorInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYearDelete;
        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYearSearch;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.ListBox listBoxDisplay;
    }
}

