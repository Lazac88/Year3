namespace Animal_Strategy_Design
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnCat = new System.Windows.Forms.RadioButton();
            this.rBtnDog = new System.Windows.Forms.RadioButton();
            this.rBtnDuck = new System.Windows.Forms.RadioButton();
            this.rBtnRabbit = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lBoxAnimals = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnRabbit);
            this.groupBox1.Controls.Add(this.rBtnDuck);
            this.groupBox1.Controls.Add(this.rBtnDog);
            this.groupBox1.Controls.Add(this.rBtnCat);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Varieties";
            // 
            // rBtnCat
            // 
            this.rBtnCat.AutoSize = true;
            this.rBtnCat.Location = new System.Drawing.Point(7, 20);
            this.rBtnCat.Name = "rBtnCat";
            this.rBtnCat.Size = new System.Drawing.Size(41, 17);
            this.rBtnCat.TabIndex = 0;
            this.rBtnCat.TabStop = true;
            this.rBtnCat.Text = "Cat";
            this.rBtnCat.UseVisualStyleBackColor = true;
            this.rBtnCat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rBtnCat_MouseDown);
            // 
            // rBtnDog
            // 
            this.rBtnDog.AutoSize = true;
            this.rBtnDog.Location = new System.Drawing.Point(6, 43);
            this.rBtnDog.Name = "rBtnDog";
            this.rBtnDog.Size = new System.Drawing.Size(45, 17);
            this.rBtnDog.TabIndex = 1;
            this.rBtnDog.TabStop = true;
            this.rBtnDog.Text = "Dog";
            this.rBtnDog.UseVisualStyleBackColor = true;
            this.rBtnDog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rBtnDog_MouseDown);
            // 
            // rBtnDuck
            // 
            this.rBtnDuck.AutoSize = true;
            this.rBtnDuck.Location = new System.Drawing.Point(6, 66);
            this.rBtnDuck.Name = "rBtnDuck";
            this.rBtnDuck.Size = new System.Drawing.Size(51, 17);
            this.rBtnDuck.TabIndex = 2;
            this.rBtnDuck.TabStop = true;
            this.rBtnDuck.Text = "Duck";
            this.rBtnDuck.UseVisualStyleBackColor = true;
            this.rBtnDuck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rBtnDuck_MouseDown);
            // 
            // rBtnRabbit
            // 
            this.rBtnRabbit.AutoSize = true;
            this.rBtnRabbit.Location = new System.Drawing.Point(6, 89);
            this.rBtnRabbit.Name = "rBtnRabbit";
            this.rBtnRabbit.Size = new System.Drawing.Size(56, 17);
            this.rBtnRabbit.TabIndex = 3;
            this.rBtnRabbit.TabStop = true;
            this.rBtnRabbit.Text = "Rabbit";
            this.rBtnRabbit.UseVisualStyleBackColor = true;
            this.rBtnRabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rBtnRabbit_MouseDown);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(192, 22);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 134);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show The Critters";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 185);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(208, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 185);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 185);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(207, 394);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(189, 185);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lBoxAnimals
            // 
            this.lBoxAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxAnimals.FormattingEnabled = true;
            this.lBoxAnimals.ItemHeight = 24;
            this.lBoxAnimals.Location = new System.Drawing.Point(434, 203);
            this.lBoxAnimals.Name = "lBoxAnimals";
            this.lBoxAnimals.Size = new System.Drawing.Size(263, 364);
            this.lBoxAnimals.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 603);
            this.Controls.Add(this.lBoxAnimals);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnRabbit;
        private System.Windows.Forms.RadioButton rBtnDuck;
        private System.Windows.Forms.RadioButton rBtnDog;
        private System.Windows.Forms.RadioButton rBtnCat;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox lBoxAnimals;
    }
}

