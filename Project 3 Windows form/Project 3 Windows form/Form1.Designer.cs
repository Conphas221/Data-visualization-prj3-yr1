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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Result = new System.Windows.Forms.Label();
            this.btnSpeedCar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTempCar = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.Label();
            this.BegDay = new System.Windows.Forms.TextBox();
            this.Begin = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Label();
            this.EndDay = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BarChart
            // 
            this.BarChart.BackColor = System.Drawing.Color.Transparent;
            this.BarChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BarChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea2";
            this.BarChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "ChartArea2";
            legend1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarChart.Legends.Add(legend1);
            this.BarChart.Location = new System.Drawing.Point(12, 12);
            this.BarChart.Name = "BarChart";
            series1.ChartArea = "ChartArea2";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "BarChart";
            this.BarChart.Series.Add(series1);
            this.BarChart.Size = new System.Drawing.Size(905, 369);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "chart1";
            this.BarChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(585, 138);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 17);
            this.Result.TabIndex = 2;
            // 
            // btnSpeedCar
            // 
            this.btnSpeedCar.BackColor = System.Drawing.Color.Aqua;
            this.btnSpeedCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSpeedCar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedCar.Location = new System.Drawing.Point(1228, 596);
            this.btnSpeedCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpeedCar.Name = "btnSpeedCar";
            this.btnSpeedCar.Size = new System.Drawing.Size(264, 28);
            this.btnSpeedCar.TabIndex = 4;
            this.btnSpeedCar.Text = "Show average speed/cars";
            this.btnSpeedCar.UseVisualStyleBackColor = false;
            this.btnSpeedCar.Click += new System.EventHandler(this.btnSpeedCar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Aqua;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(15, 596);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Aqua;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(112, 596);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTempCar
            // 
            this.btnTempCar.BackColor = System.Drawing.Color.Aqua;
            this.btnTempCar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempCar.Location = new System.Drawing.Point(628, 597);
            this.btnTempCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTempCar.Name = "btnTempCar";
            this.btnTempCar.Size = new System.Drawing.Size(263, 28);
            this.btnTempCar.TabIndex = 7;
            this.btnTempCar.Text = "Show average temp/cars";
            this.btnTempCar.UseVisualStyleBackColor = false;
            this.btnTempCar.Click += new System.EventHandler(this.btnTempCar_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackColor = System.Drawing.Color.Aqua;
            this.btnSpeed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeed.Location = new System.Drawing.Point(896, 596);
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(325, 28);
            this.btnSpeed.TabIndex = 8;
            this.btnSpeed.Text = "Show average speed at 2 locations";
            this.btnSpeed.UseVisualStyleBackColor = false;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.BackColor = System.Drawing.Color.Cyan;
            this.Day.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.Location = new System.Drawing.Point(276, 553);
            this.Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(45, 23);
            this.Day.TabIndex = 11;
            this.Day.Text = "Day";
            // 
            // BegDay
            // 
            this.BegDay.Location = new System.Drawing.Point(207, 505);
            this.BegDay.Margin = new System.Windows.Forms.Padding(4);
            this.BegDay.Name = "BegDay";
            this.BegDay.Size = new System.Drawing.Size(68, 22);
            this.BegDay.TabIndex = 13;
            // 
            // Begin
            // 
            this.Begin.AutoSize = true;
            this.Begin.BackColor = System.Drawing.Color.Cyan;
            this.Begin.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin.Location = new System.Drawing.Point(203, 553);
            this.Begin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(62, 23);
            this.Begin.TabIndex = 17;
            this.Begin.Text = "Begin";
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.Cyan;
            this.FilterButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(244, 596);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(4);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(100, 28);
            this.FilterButton.TabIndex = 19;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.BackColor = System.Drawing.Color.Cyan;
            this.End.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(344, 553);
            this.End.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(44, 23);
            this.End.TabIndex = 18;
            this.End.Text = "End";
            // 
            // EndDay
            // 
            this.EndDay.Location = new System.Drawing.Point(327, 505);
            this.EndDay.Margin = new System.Windows.Forms.Padding(4);
            this.EndDay.Name = "EndDay";
            this.EndDay.Size = new System.Drawing.Size(63, 22);
            this.EndDay.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Oktober",
            "November",
            "December"});
            this.comboBox1.Location = new System.Drawing.Point(460, 549);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 23);
            this.comboBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(460, 597);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_3_Windows_form.Properties.Resources._13_4_2017_rotterdam5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1653, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.EndDay);
            this.Controls.Add(this.BegDay);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnTempCar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSpeedCar);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.BarChart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button btnSpeedCar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTempCar;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.TextBox BegDay;
        private System.Windows.Forms.Label Begin;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.TextBox EndDay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

