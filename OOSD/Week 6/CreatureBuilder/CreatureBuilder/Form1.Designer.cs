namespace CreatureBuilder
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
            this.comboHead = new System.Windows.Forms.ComboBox();
            this.comboBody = new System.Windows.Forms.ComboBox();
            this.comboFeet = new System.Windows.Forms.ComboBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblFeet = new System.Windows.Forms.Label();
            this.btnCreateCreature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboHead
            // 
            this.comboHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHead.FormattingEnabled = true;
            this.comboHead.Location = new System.Drawing.Point(438, 149);
            this.comboHead.Name = "comboHead";
            this.comboHead.Size = new System.Drawing.Size(121, 21);
            this.comboHead.TabIndex = 0;
            // 
            // comboBody
            // 
            this.comboBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBody.FormattingEnabled = true;
            this.comboBody.Location = new System.Drawing.Point(438, 385);
            this.comboBody.Name = "comboBody";
            this.comboBody.Size = new System.Drawing.Size(121, 21);
            this.comboBody.TabIndex = 1;
            // 
            // comboFeet
            // 
            this.comboFeet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFeet.FormattingEnabled = true;
            this.comboFeet.Location = new System.Drawing.Point(438, 613);
            this.comboFeet.Name = "comboFeet";
            this.comboFeet.Size = new System.Drawing.Size(121, 21);
            this.comboFeet.TabIndex = 2;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(434, 99);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(60, 24);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "Head";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(434, 339);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(57, 24);
            this.lblBody.TabIndex = 4;
            this.lblBody.Text = "Body";
            // 
            // lblFeet
            // 
            this.lblFeet.AutoSize = true;
            this.lblFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeet.Location = new System.Drawing.Point(438, 571);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(52, 24);
            this.lblFeet.TabIndex = 5;
            this.lblFeet.Text = "Feet";
            // 
            // btnCreateCreature
            // 
            this.btnCreateCreature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCreature.Location = new System.Drawing.Point(260, 736);
            this.btnCreateCreature.Name = "btnCreateCreature";
            this.btnCreateCreature.Size = new System.Drawing.Size(121, 58);
            this.btnCreateCreature.TabIndex = 6;
            this.btnCreateCreature.Text = "Create Creature";
            this.btnCreateCreature.UseVisualStyleBackColor = true;
            this.btnCreateCreature.Click += new System.EventHandler(this.btnCreateCreature_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 806);
            this.Controls.Add(this.btnCreateCreature);
            this.Controls.Add(this.lblFeet);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.comboFeet);
            this.Controls.Add(this.comboBody);
            this.Controls.Add(this.comboHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboHead;
        private System.Windows.Forms.ComboBox comboBody;
        private System.Windows.Forms.ComboBox comboFeet;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblFeet;
        private System.Windows.Forms.Button btnCreateCreature;
    }
}

