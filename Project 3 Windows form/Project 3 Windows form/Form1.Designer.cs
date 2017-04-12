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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Result = new System.Windows.Forms.Label();
            this.btnMinToDay = new System.Windows.Forms.Button();
            this.btnSpeedCar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTempCar = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BarChart
            // 
            this.BarChart.BackColor = System.Drawing.Color.Transparent;
            this.BarChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BarChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea2";
            this.BarChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.DockedToChartArea = "ChartArea2";
            legend2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsDockedInsideChartArea = false;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarChart.Legends.Add(legend2);
            this.BarChart.Location = new System.Drawing.Point(12, 12);
            this.BarChart.Name = "BarChart";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "BarChart";
            this.BarChart.Series.Add(series2);
            this.BarChart.Size = new System.Drawing.Size(905, 369);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "chart1";
            this.BarChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(439, 112);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 2;
            // 
            // btnMinToDay
            // 
            this.btnMinToDay.Location = new System.Drawing.Point(1045, 33);
            this.btnMinToDay.Name = "btnMinToDay";
            this.btnMinToDay.Size = new System.Drawing.Size(52, 21);
            this.btnMinToDay.TabIndex = 3;
            this.btnMinToDay.Text = "Convert minutes to days";
            this.btnMinToDay.UseVisualStyleBackColor = true;
            this.btnMinToDay.Click += new System.EventHandler(this.btnMinToDay_Click);
            // 
            // btnSpeedCar
            // 
            this.btnSpeedCar.BackColor = System.Drawing.Color.Aqua;
            this.btnSpeedCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSpeedCar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedCar.Location = new System.Drawing.Point(921, 484);
            this.btnSpeedCar.Name = "btnSpeedCar";
            this.btnSpeedCar.Size = new System.Drawing.Size(198, 23);
            this.btnSpeedCar.TabIndex = 4;
            this.btnSpeedCar.Text = "Show average speed/cars";
            this.btnSpeedCar.UseVisualStyleBackColor = false;
            this.btnSpeedCar.Click += new System.EventHandler(this.btnSpeedCar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Aqua;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(11, 484);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Aqua;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(84, 484);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 24);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTempCar
            // 
            this.btnTempCar.BackColor = System.Drawing.Color.Aqua;
            this.btnTempCar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempCar.Location = new System.Drawing.Point(471, 485);
            this.btnTempCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnTempCar.Name = "btnTempCar";
            this.btnTempCar.Size = new System.Drawing.Size(197, 23);
            this.btnTempCar.TabIndex = 7;
            this.btnTempCar.Text = "Show average temp/cars";
            this.btnTempCar.UseVisualStyleBackColor = false;
            this.btnTempCar.Click += new System.EventHandler(this.btnTempCar_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackColor = System.Drawing.Color.Aqua;
            this.btnSpeed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeed.Location = new System.Drawing.Point(672, 484);
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(244, 23);
            this.btnSpeed.TabIndex = 8;
            this.btnSpeed.Text = "Show average speed at 2 locations";
            this.btnSpeed.UseVisualStyleBackColor = false;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_3_Windows_form.Properties.Resources._2011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 553);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnTempCar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSpeedCar);
            this.Controls.Add(this.btnMinToDay);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.BarChart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button btnMinToDay;
        private System.Windows.Forms.Button btnSpeedCar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTempCar;
        private System.Windows.Forms.Button btnSpeed;
    }
}

