namespace WeatherSubjectObserver
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
            this.btnUpdateWeather = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblBar = new System.Windows.Forms.Label();
            this.lblDataTemp = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblForecast = new System.Windows.Forms.Label();
            this.txtBoxTemp = new System.Windows.Forms.TextBox();
            this.txtBoxHumid = new System.Windows.Forms.TextBox();
            this.txtBoxPressure = new System.Windows.Forms.TextBox();
            this.listBoxToday = new System.Windows.Forms.ListBox();
            this.listBoxAverage = new System.Windows.Forms.ListBox();
            this.listBoxForecast = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUpdateWeather
            // 
            this.btnUpdateWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWeather.Location = new System.Drawing.Point(13, 29);
            this.btnUpdateWeather.Name = "btnUpdateWeather";
            this.btnUpdateWeather.Size = new System.Drawing.Size(209, 78);
            this.btnUpdateWeather.TabIndex = 0;
            this.btnUpdateWeather.Text = "Update Measurements";
            this.btnUpdateWeather.UseVisualStyleBackColor = true;
            this.btnUpdateWeather.Click += new System.EventHandler(this.btnUpdateWeather_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(13, 154);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(164, 24);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temperature (C)";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(13, 292);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(127, 24);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity (%)";
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBar.Location = new System.Drawing.Point(13, 452);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(199, 24);
            this.lblBar.TabIndex = 3;
            this.lblBar.Text = "Barometric Pressure";
            // 
            // lblDataTemp
            // 
            this.lblDataTemp.AutoSize = true;
            this.lblDataTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTemp.Location = new System.Drawing.Point(556, 83);
            this.lblDataTemp.Name = "lblDataTemp";
            this.lblDataTemp.Size = new System.Drawing.Size(148, 24);
            this.lblDataTemp.TabIndex = 4;
            this.lblDataTemp.Text = "Latest Reading";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(556, 262);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(172, 24);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average Reading";
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecast.Location = new System.Drawing.Point(556, 452);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(91, 24);
            this.lblForecast.TabIndex = 6;
            this.lblForecast.Text = "Forecast";
            // 
            // txtBoxTemp
            // 
            this.txtBoxTemp.Location = new System.Drawing.Point(17, 212);
            this.txtBoxTemp.Name = "txtBoxTemp";
            this.txtBoxTemp.Size = new System.Drawing.Size(160, 20);
            this.txtBoxTemp.TabIndex = 7;
            // 
            // txtBoxHumid
            // 
            this.txtBoxHumid.Location = new System.Drawing.Point(17, 345);
            this.txtBoxHumid.Name = "txtBoxHumid";
            this.txtBoxHumid.Size = new System.Drawing.Size(160, 20);
            this.txtBoxHumid.TabIndex = 8;
            // 
            // txtBoxPressure
            // 
            this.txtBoxPressure.Location = new System.Drawing.Point(17, 511);
            this.txtBoxPressure.Name = "txtBoxPressure";
            this.txtBoxPressure.Size = new System.Drawing.Size(160, 20);
            this.txtBoxPressure.TabIndex = 9;
            // 
            // listBoxToday
            // 
            this.listBoxToday.FormattingEnabled = true;
            this.listBoxToday.Location = new System.Drawing.Point(560, 111);
            this.listBoxToday.Name = "listBoxToday";
            this.listBoxToday.Size = new System.Drawing.Size(430, 147);
            this.listBoxToday.TabIndex = 10;
            // 
            // listBoxAverage
            // 
            this.listBoxAverage.FormattingEnabled = true;
            this.listBoxAverage.Location = new System.Drawing.Point(560, 289);
            this.listBoxAverage.Name = "listBoxAverage";
            this.listBoxAverage.Size = new System.Drawing.Size(430, 147);
            this.listBoxAverage.TabIndex = 11;
            // 
            // listBoxForecast
            // 
            this.listBoxForecast.FormattingEnabled = true;
            this.listBoxForecast.Location = new System.Drawing.Point(560, 479);
            this.listBoxForecast.Name = "listBoxForecast";
            this.listBoxForecast.Size = new System.Drawing.Size(430, 147);
            this.listBoxForecast.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 707);
            this.Controls.Add(this.listBoxForecast);
            this.Controls.Add(this.listBoxAverage);
            this.Controls.Add(this.listBoxToday);
            this.Controls.Add(this.txtBoxPressure);
            this.Controls.Add(this.txtBoxHumid);
            this.Controls.Add(this.txtBoxTemp);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblDataTemp);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnUpdateWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateWeather;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label lblDataTemp;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.TextBox txtBoxTemp;
        private System.Windows.Forms.TextBox txtBoxHumid;
        private System.Windows.Forms.TextBox txtBoxPressure;
        private System.Windows.Forms.ListBox listBoxToday;
        private System.Windows.Forms.ListBox listBoxAverage;
        private System.Windows.Forms.ListBox listBoxForecast;
    }
}

