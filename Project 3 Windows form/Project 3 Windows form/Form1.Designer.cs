namespace Project_3_Windows_form
{
    partial class Form1
    {
        Game game = new Game();
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BarChart
            // 
            chartArea9.Name = "ChartArea1";
            chartArea10.Name = "ChartArea2";
            this.BarChart.ChartAreas.Add(chartArea9);
            this.BarChart.ChartAreas.Add(chartArea10);
            legend5.Name = "Legend1";
            this.BarChart.Legends.Add(legend5);
            this.BarChart.Location = new System.Drawing.Point(12, 12);
            this.BarChart.Name = "BarChart";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.Points.Add(dataPoint25);
            series9.Points.Add(dataPoint26);
            series9.Points.Add(dataPoint27);
            series9.Points.Add(dataPoint28);
            series9.Points.Add(dataPoint29);
            series9.Points.Add(dataPoint30);
            series10.ChartArea = "ChartArea2";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series10.Legend = "Legend1";
            series10.Name = "BarChart";
            this.BarChart.Series.Add(series9);
            this.BarChart.Series.Add(series10);
            this.BarChart.Size = new System.Drawing.Size(300, 300);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "chart1";
            this.BarChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Count all speeds";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(439, 112);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Convert minutes to days";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BarChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button button2;
    }
}

