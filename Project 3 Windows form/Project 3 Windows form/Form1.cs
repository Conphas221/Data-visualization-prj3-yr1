using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_3_Windows_form.Imports;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_3_Windows_form
{
    public partial class Form1 : Form
    {
        int graph = 1;
        A13Import Importer = new A13Import();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            graph = 0;
            FilterButton.Enabled = true;
            button1.Enabled = true;
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Series.Add("Average speed");
            BarChart.Size = new Size(650, 500);
            BarChart.Location = new System.Drawing.Point(290, 0);
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            BarChart.Series[0].Color = Color.Red;
            BarChart.Series[0].BorderColor = Color.CornflowerBlue;
            BarChart.BackColor = Color.FromArgb(255, 222, 251);
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            BarChart.Titles.Add("Average car speed");
            int count = 1;
            List<int> AVGspeeds = Importer.ImportAVGdailySpeed();
            BarChart.Series["Average speed"].Points.DataBindY(AVGspeeds.ToArray());
            count = count + 1;
         }

        private void btnMinToDay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to convert the speeds?", "convert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Converter convert = new Converter();
                convert.ConvertDatabaseToNewList(Importer.ImportSpeeds());
            }

        }

        private void btnSpeedCar_Click(object sender, EventArgs e)
        {
            // gemiddelde snelheid lijst int & deze snelheden toevoegd aan de barchart
            this.graph = 1;
            FilterButton.Enabled = true;
            button1.Enabled = true;
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Size = new System.Drawing.Size(1172, 377);
            BarChart.Location = new System.Drawing.Point(11, 10);
            BarChart.Series.Add("Average speed");
            BarChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            BarChart.Series[0].Color = Color.LightSkyBlue;
            BarChart.Series[0].BorderColor = Color.DeepSkyBlue;
            BarChart.BackColor = Color.FromArgb(238, 243, 255);
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            BarChart.Titles.Add("Average speed & amount of cars");
            DateTime count = new DateTime(2011, 01, 1);
            List<int> AVGspeeds = Importer.ImportAVGdailySpeed();
            foreach (var item in AVGspeeds)
            {
                BarChart.Series["Average speed"].Points.Add(new DataPoint(count.ToOADate(), item));
                count = count.AddDays(1);
            }

            BarChart.Series.Add("Average car amount");
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            BarChart.Series[1].Color = Color.Gray;
            BarChart.Series[1].BorderColor = Color.DarkGray;

            count = new DateTime(2011, 01, 1);

            List<int> AVGcars = Importer.ImportAVGCarsAmount();
            foreach (var item in AVGcars)
            {
                BarChart.Series["Average car amount"].Points.Add(new DataPoint(count.ToOADate(), item));
                count = count.AddDays(1);
            }
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            this.graph = 2;
            FilterButton.Enabled = true;
            button1.Enabled = true;
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Location = new System.Drawing.Point(11, 10);
            BarChart.Size = new System.Drawing.Size(1172, 377);
            BarChart.Series.Add("Mijlpaal 1");
            BarChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            BarChart.Series[0].Color = Color.ForestGreen;
            BarChart.Series[0].BorderColor = Color.OrangeRed;
            BarChart.BackColor = Color.FromArgb(255,255,209);
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            BarChart.Titles.Add("Average speed at different locations");
            DateTime count = new DateTime(2011, 01, 1);

            List<Tuple<int,int>> ValueNodes = Importer.Import2CarAverage();

            foreach (Tuple<int,int> item in ValueNodes)
            {
                BarChart.Series["Mijlpaal 1"].Points.Add(new DataPoint(count.ToOADate(), item.Item1));
                count = count.AddDays(1);
            }

            BarChart.Series.Add("Mijlpaal 2");
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line ;

            count = new DateTime(2011, 01, 1);
            foreach (Tuple<int,int> item in ValueNodes)
            {
                BarChart.Series["Mijlpaal 2"].Points.Add(new DataPoint(count.ToOADate(), item.Item2));
                count = count.AddDays(1);
            }
        }

        private void btnTempCar_Click(object sender, EventArgs e)
        {
            this.graph = 3;
            FilterButton.Enabled = true;
            button1.Enabled = true;
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Location = new System.Drawing.Point(11, 10);
            BarChart.Size = new System.Drawing.Size(1172, 377);
            BarChart.Series.Add("Average temperature");
            BarChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            BarChart.Series[0].Color = Color.HotPink;
            BarChart.Series[0].BorderColor = Color.PeachPuff;
            BarChart.BackColor = Color.FromArgb(255, 242, 247);
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            BarChart.Titles.Add("Temperature & amount of cars");
            DateTime count = new DateTime(2011, 01, 1);

            List<Tuple<int,int>> ValueNodes = Importer.ImportWeatherAndCars();

            foreach (Tuple<int,int> item in ValueNodes)
            {
                BarChart.Series["Average temperature"].Points.Add(new DataPoint(count.ToOADate(), item.Item1));
                count = count.AddDays(1);
            }

            BarChart.Series.Add("Average car amount");
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            count = new DateTime(2011, 01, 1);
            foreach (Tuple<int,int> item in ValueNodes)
            {
                BarChart.Series["Average car amount"].Points.AddXY(count, item.Item2);
                count = count.AddDays(1);
            }
        }
        private void fill_charts(string Title, string dataSource1, string DataSource2, List<Tuple<int,int>> List)
        {
            FilterButton.Enabled = true;
            button1.Enabled = true;
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Series.Add(dataSource1);
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            BarChart.Series[0].Color = Color.Gray;
            BarChart.Series[0].BorderColor = Color.LightBlue;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            BarChart.Titles.Add(Title);
            int count = 1;

            foreach (Tuple<int,int> item in List)
            {
                BarChart.Series[dataSource1].Points.AddXY(count, item.Item1);
                count = count + 1;
            }

            BarChart.Series.Add(DataSource2);
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            count = 1;
            foreach (Tuple<int,int> item in List)
            {
                BarChart.Series[DataSource2].Points.AddXY(count, item.Item2);
                count = count + 1;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            FilterButton.Enabled = false;
            button1.Enabled = false;
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convert2_Click(object sender, EventArgs e)
        {
            Converter convert = new Converter();
            convert.ConvertDatabaseToNewList(Importer.ImportSpeeds());
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            resetchart(sender, e);
            if (BegDay.Text.Length > 0 && BegMonth.Text.Length > 0)
            {
                bool text = true;
                foreach (char letter in BegDay.Text)
                {if (!char.IsDigit(letter)){text = false;}
                }
                foreach (char letter in BegMonth.Text)
                {if (!char.IsDigit(letter)){text = false;}
                }
                foreach (char letter in EndDay.Text)
                {if (!char.IsDigit(letter)){ text = false;}
                }
                foreach (char letter in EndMonth.Text)
                {if (!char.IsDigit(letter)){ text = false;}
                }

                int BeginningMonth = Int32.Parse(BegMonth.Text);
                int BeginningDay = Int32.Parse(BegDay.Text);
                int EndingMonth= Int32.Parse(EndMonth.Text);
                int EndingDay = Int32.Parse(EndDay.Text);

                if ((1 >= BeginningDay) && (BeginningDay <= 31) && (1 >= EndingDay) && (EndingDay <= 31)) { text = false; }
                if ((1 >= BeginningMonth) && (BeginningDay <= 12) && (1 >= EndingMonth) && (EndingMonth <= 12)) { text = false; }
                if (text == true)
                {
                    DateTime begin = new DateTime(2011, BeginningMonth, BeginningDay);
                    DateTime end = new DateTime(2011, EndingMonth, EndingDay);

                    DataFilter filter = new DataFilter(begin, end);
                    BarChart.DataManipulator.Filter(filter, BarChart.Series[0]);
                    BarChart.DataManipulator.Filter(filter, BarChart.Series[1]);
                }else
                {
                    MessageBox.Show("The given filter is not correct");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetchart(sender, e);
            DateTime begin= new DateTime();
            DateTime end = new DateTime();
            string result = comboBox1.Text;

            if (result == "December") { begin = new DateTime(2011,11,30); end = new DateTime(2012, 1, 1); }
            else if (result == "Februari") { begin = new DateTime(2011, 1, 31); end = new DateTime(2011, 3, 1); }
            else if (result == "March") { begin = new DateTime(2011, 2, 28); end = new DateTime(2011, 4, 1); }
            else if (result == "April") { begin = new DateTime(2011, 3, 31); end = new DateTime(2011, 5, 1); }
            else if (result == "May") { begin = new DateTime(2011, 4, 30); end = new DateTime(2011, 6, 1); }
            else if (result == "June") { begin = new DateTime(2011, 5, 31); end = new DateTime(2011, 7, 1); }
            else if (result == "July") { begin = new DateTime(2011, 6, 30); end = new DateTime(2011, 8, 1); }
            else if (result == "August") { begin = new DateTime(2011, 7, 31); end = new DateTime(2011, 9, 1); }
            else if (result == "September") { begin = new DateTime(2011, 8, 31); end = new DateTime(2011, 10, 1); }
            else if (result == "Oktober") { begin = new DateTime(2011, 9, 30); end = new DateTime(2011, 11, 1); }
            else if (result == "November") { begin = new DateTime(2011, 10, 31); end = new DateTime(2011, 12, 1); }
            else { begin = new DateTime(2010, 12, 31); end = new DateTime(2011, 2, 1); }

            DataFilter filter = new DataFilter(begin, end);
            BarChart.DataManipulator.Filter(filter, BarChart.Series[0]);
            BarChart.DataManipulator.Filter(filter, BarChart.Series[1]);
        }
        public void resetchart(object sender, EventArgs e)
        {
            if (graph == 1)
            {
                btnSpeedCar_Click(sender, e);
            }
            else if (graph == 2)
            {
                btnSpeed_Click(sender, e);

            }
            else
            {
                btnTempCar_Click(sender, e);
            }
        }
    }

    public class DataFilter : IDataPointFilter
    {
        DateTime beg;
        DateTime end;

        public DataFilter (DateTime beginning, DateTime ending)
        {
            this.beg = beginning;
            this.end = ending;
        }
        public bool FilterDataPoint(DataPoint point, Series series, Int32 filter_on)
        {
            if ((point.XValue <= beg.ToOADate())|| (point.XValue >= end.ToOADate()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
