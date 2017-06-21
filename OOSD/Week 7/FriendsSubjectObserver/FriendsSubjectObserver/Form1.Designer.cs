namespace FriendsSubjectObserver
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabFriend1 = new System.Windows.Forms.TabPage();
            this.tabFriend2 = new System.Windows.Forms.TabPage();
            this.tabFriend3 = new System.Windows.Forms.TabPage();
            this.tabFriend4 = new System.Windows.Forms.TabPage();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.listBoxFriend1 = new System.Windows.Forms.ListBox();
            this.listBoxFriend2 = new System.Windows.Forms.ListBox();
            this.listBoxFriend3 = new System.Windows.Forms.ListBox();
            this.listBoxFriend4 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabFriend1.SuspendLayout();
            this.tabFriend2.SuspendLayout();
            this.tabFriend3.SuspendLayout();
            this.tabFriend4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabFriend1);
            this.tabControl1.Controls.Add(this.tabFriend2);
            this.tabControl1.Controls.Add(this.tabFriend3);
            this.tabControl1.Controls.Add(this.tabFriend4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.listBoxMain);
            this.tabMain.Controls.Add(this.btnPost);
            this.tabMain.Controls.Add(this.txtBoxInput);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(625, 515);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main Page";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabFriend1
            // 
            this.tabFriend1.Controls.Add(this.listBoxFriend1);
            this.tabFriend1.Location = new System.Drawing.Point(4, 22);
            this.tabFriend1.Name = "tabFriend1";
            this.tabFriend1.Size = new System.Drawing.Size(625, 515);
            this.tabFriend1.TabIndex = 1;
            this.tabFriend1.Text = "Friend 1";
            this.tabFriend1.UseVisualStyleBackColor = true;
            // 
            // tabFriend2
            // 
            this.tabFriend2.Controls.Add(this.listBoxFriend2);
            this.tabFriend2.Location = new System.Drawing.Point(4, 22);
            this.tabFriend2.Name = "tabFriend2";
            this.tabFriend2.Size = new System.Drawing.Size(625, 515);
            this.tabFriend2.TabIndex = 2;
            this.tabFriend2.Text = "Friend 2";
            this.tabFriend2.UseVisualStyleBackColor = true;
            // 
            // tabFriend3
            // 
            this.tabFriend3.Controls.Add(this.listBoxFriend3);
            this.tabFriend3.Location = new System.Drawing.Point(4, 22);
            this.tabFriend3.Name = "tabFriend3";
            this.tabFriend3.Size = new System.Drawing.Size(625, 515);
            this.tabFriend3.TabIndex = 3;
            this.tabFriend3.Text = "Friend 3";
            this.tabFriend3.UseVisualStyleBackColor = true;
            // 
            // tabFriend4
            // 
            this.tabFriend4.Controls.Add(this.listBoxFriend4);
            this.tabFriend4.Location = new System.Drawing.Point(4, 22);
            this.tabFriend4.Name = "tabFriend4";
            this.tabFriend4.Size = new System.Drawing.Size(625, 515);
            this.tabFriend4.TabIndex = 4;
            this.tabFriend4.Text = "Friend 4";
            this.tabFriend4.UseVisualStyleBackColor = true;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.Location = new System.Drawing.Point(4, 444);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(402, 22);
            this.txtBoxInput.TabIndex = 0;
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(429, 444);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(193, 68);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // listBoxMain
            // 
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(4, 4);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(610, 433);
            this.listBoxMain.TabIndex = 2;
            // 
            // listBoxFriend1
            // 
            this.listBoxFriend1.FormattingEnabled = true;
            this.listBoxFriend1.Location = new System.Drawing.Point(4, 19);
            this.listBoxFriend1.Name = "listBoxFriend1";
            this.listBoxFriend1.Size = new System.Drawing.Size(618, 446);
            this.listBoxFriend1.TabIndex = 0;
            // 
            // listBoxFriend2
            // 
            this.listBoxFriend2.FormattingEnabled = true;
            this.listBoxFriend2.Location = new System.Drawing.Point(4, 20);
            this.listBoxFriend2.Name = "listBoxFriend2";
            this.listBoxFriend2.Size = new System.Drawing.Size(618, 446);
            this.listBoxFriend2.TabIndex = 0;
            // 
            // listBoxFriend3
            // 
            this.listBoxFriend3.FormattingEnabled = true;
            this.listBoxFriend3.Location = new System.Drawing.Point(4, 29);
            this.listBoxFriend3.Name = "listBoxFriend3";
            this.listBoxFriend3.Size = new System.Drawing.Size(618, 446);
            this.listBoxFriend3.TabIndex = 0;
            // 
            // listBoxFriend4
            // 
            this.listBoxFriend4.FormattingEnabled = true;
            this.listBoxFriend4.Location = new System.Drawing.Point(4, 28);
            this.listBoxFriend4.Name = "listBoxFriend4";
            this.listBoxFriend4.Size = new System.Drawing.Size(618, 433);
            this.listBoxFriend4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabFriend1.ResumeLayout(false);
            this.tabFriend2.ResumeLayout(false);
            this.tabFriend3.ResumeLayout(false);
            this.tabFriend4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TabPage tabFriend1;
        private System.Windows.Forms.ListBox listBoxFriend1;
        private System.Windows.Forms.TabPage tabFriend2;
        private System.Windows.Forms.ListBox listBoxFriend2;
        private System.Windows.Forms.TabPage tabFriend3;
        private System.Windows.Forms.ListBox listBoxFriend3;
        private System.Windows.Forms.TabPage tabFriend4;
        private System.Windows.Forms.ListBox listBoxFriend4;
    }
}

