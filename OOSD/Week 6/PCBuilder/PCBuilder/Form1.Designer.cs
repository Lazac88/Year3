namespace PCBuilder
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
            this.btnPrintSpec = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.grpBoxMachineType = new System.Windows.Forms.GroupBox();
            this.rBtnMultimedia = new System.Windows.Forms.RadioButton();
            this.rBtnBusiness = new System.Windows.Forms.RadioButton();
            this.rBtnGame = new System.Windows.Forms.RadioButton();
            this.rBtnHome = new System.Windows.Forms.RadioButton();
            this.grpBoxMachineType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintSpec
            // 
            this.btnPrintSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSpec.Location = new System.Drawing.Point(13, 13);
            this.btnPrintSpec.Name = "btnPrintSpec";
            this.btnPrintSpec.Size = new System.Drawing.Size(120, 54);
            this.btnPrintSpec.TabIndex = 0;
            this.btnPrintSpec.Text = "Print Specs";
            this.btnPrintSpec.UseVisualStyleBackColor = true;
            this.btnPrintSpec.Click += new System.EventHandler(this.btnPrintSpec_Click);
            // 
            // displayBox
            // 
            this.displayBox.FormattingEnabled = true;
            this.displayBox.Location = new System.Drawing.Point(140, 13);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(373, 277);
            this.displayBox.TabIndex = 1;
            // 
            // grpBoxMachineType
            // 
            this.grpBoxMachineType.Controls.Add(this.rBtnHome);
            this.grpBoxMachineType.Controls.Add(this.rBtnMultimedia);
            this.grpBoxMachineType.Controls.Add(this.rBtnBusiness);
            this.grpBoxMachineType.Controls.Add(this.rBtnGame);
            this.grpBoxMachineType.Location = new System.Drawing.Point(13, 83);
            this.grpBoxMachineType.Name = "grpBoxMachineType";
            this.grpBoxMachineType.Size = new System.Drawing.Size(109, 207);
            this.grpBoxMachineType.TabIndex = 2;
            this.grpBoxMachineType.TabStop = false;
            this.grpBoxMachineType.Text = "Machine Type";
            // 
            // rBtnMultimedia
            // 
            this.rBtnMultimedia.AutoSize = true;
            this.rBtnMultimedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMultimedia.Location = new System.Drawing.Point(6, 114);
            this.rBtnMultimedia.Name = "rBtnMultimedia";
            this.rBtnMultimedia.Size = new System.Drawing.Size(91, 20);
            this.rBtnMultimedia.TabIndex = 2;
            this.rBtnMultimedia.TabStop = true;
            this.rBtnMultimedia.Text = "Multimedia";
            this.rBtnMultimedia.UseVisualStyleBackColor = true;
            // 
            // rBtnBusiness
            // 
            this.rBtnBusiness.AutoSize = true;
            this.rBtnBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnBusiness.Location = new System.Drawing.Point(6, 73);
            this.rBtnBusiness.Name = "rBtnBusiness";
            this.rBtnBusiness.Size = new System.Drawing.Size(81, 20);
            this.rBtnBusiness.TabIndex = 1;
            this.rBtnBusiness.TabStop = true;
            this.rBtnBusiness.Text = "Business";
            this.rBtnBusiness.UseVisualStyleBackColor = true;
            // 
            // rBtnGame
            // 
            this.rBtnGame.AutoSize = true;
            this.rBtnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnGame.Location = new System.Drawing.Point(6, 34);
            this.rBtnGame.Name = "rBtnGame";
            this.rBtnGame.Size = new System.Drawing.Size(63, 20);
            this.rBtnGame.TabIndex = 0;
            this.rBtnGame.TabStop = true;
            this.rBtnGame.Text = "Game";
            this.rBtnGame.UseVisualStyleBackColor = true;
            // 
            // rBtnHome
            // 
            this.rBtnHome.AutoSize = true;
            this.rBtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnHome.Location = new System.Drawing.Point(6, 154);
            this.rBtnHome.Name = "rBtnHome";
            this.rBtnHome.Size = new System.Drawing.Size(63, 20);
            this.rBtnHome.TabIndex = 3;
            this.rBtnHome.TabStop = true;
            this.rBtnHome.Text = "Home";
            this.rBtnHome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 358);
            this.Controls.Add(this.grpBoxMachineType);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.btnPrintSpec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxMachineType.ResumeLayout(false);
            this.grpBoxMachineType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintSpec;
        private System.Windows.Forms.ListBox displayBox;
        private System.Windows.Forms.GroupBox grpBoxMachineType;
        private System.Windows.Forms.RadioButton rBtnMultimedia;
        private System.Windows.Forms.RadioButton rBtnBusiness;
        private System.Windows.Forms.RadioButton rBtnGame;
        private System.Windows.Forms.RadioButton rBtnHome;
    }
}

