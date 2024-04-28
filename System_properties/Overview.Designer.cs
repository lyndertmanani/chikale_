namespace Green_house_chikale.System_properties
{
    partial class Overview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLog = new System.Windows.Forms.Label();
            this.AuthnUser = new System.Windows.Forms.Label();
            this.recommendationLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.celciusLabel = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.Winds = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TimeLog
            // 
            this.TimeLog.AutoSize = true;
            this.TimeLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLog.Location = new System.Drawing.Point(814, 19);
            this.TimeLog.Name = "TimeLog";
            this.TimeLog.Size = new System.Drawing.Size(105, 19);
            this.TimeLog.TabIndex = 0;
            this.TimeLog.Text = "Today\'s Plan";
            // 
            // AuthnUser
            // 
            this.AuthnUser.AutoSize = true;
            this.AuthnUser.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.AuthnUser.Location = new System.Drawing.Point(76, 42);
            this.AuthnUser.Name = "AuthnUser";
            this.AuthnUser.Size = new System.Drawing.Size(109, 15);
            this.AuthnUser.TabIndex = 0;
            this.AuthnUser.Text = "email@domain.com";
            // 
            // recommendationLabel
            // 
            this.recommendationLabel.AutoSize = true;
            this.recommendationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendationLabel.Location = new System.Drawing.Point(88, 153);
            this.recommendationLabel.Name = "recommendationLabel";
            this.recommendationLabel.Size = new System.Drawing.Size(97, 19);
            this.recommendationLabel.TabIndex = 0;
            this.recommendationLabel.Text = "......................";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gray;
            chartArea1.BorderColor = System.Drawing.Color.Gray;
            chartArea1.Name = "Cost Analysis";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.Gray;
            legend1.HeaderSeparatorColor = System.Drawing.Color.DarkGray;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.DarkGray;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.DimGray;
            legend1.TitleSeparatorColor = System.Drawing.Color.DimGray;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(26, 240);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "Cost Analysis";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.LabelForeColor = System.Drawing.Color.DarkGray;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(870, 275);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // celciusLabel
            // 
            this.celciusLabel.AutoSize = true;
            this.celciusLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.celciusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celciusLabel.Location = new System.Drawing.Point(92, 94);
            this.celciusLabel.Name = "celciusLabel";
            this.celciusLabel.Size = new System.Drawing.Size(67, 19);
            this.celciusLabel.TabIndex = 4;
            this.celciusLabel.Text = "celcius ";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Humidity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.Location = new System.Drawing.Point(297, 94);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(81, 19);
            this.Humidity.TabIndex = 4;
            this.Humidity.Text = " humidity";
            // 
            // Winds
            // 
            this.Winds.AutoSize = true;
            this.Winds.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Winds.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winds.Location = new System.Drawing.Point(516, 94);
            this.Winds.Name = "Winds";
            this.Winds.Size = new System.Drawing.Size(99, 19);
            this.Winds.TabIndex = 4;
            this.Winds.Text = " windspeed";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pressureLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.Location = new System.Drawing.Point(753, 94);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(72, 19);
            this.pressureLabel.TabIndex = 4;
            this.pressureLabel.Text = "pressure";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(26, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 59);
            this.panel1.TabIndex = 5;
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            this.DateTime.Location = new System.Drawing.Point(22, 151);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(65, 21);
            this.DateTime.TabIndex = 0;
            this.DateTime.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expenditure overview";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.Winds);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.celciusLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TimeLog);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthnUser);
            this.Controls.Add(this.recommendationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(965, 678);
            this.Load += new System.EventHandler(this.Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLog;
        private System.Windows.Forms.Label AuthnUser;
        private System.Windows.Forms.Label recommendationLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label celciusLabel;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Winds;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Label label3;
    }
}
