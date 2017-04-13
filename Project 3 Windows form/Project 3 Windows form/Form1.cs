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
        A13Import Importer = new A13Import();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Series.Add("Average speed");
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi;
            BarChart.Series[0].Color = Color.Gray;
            BarChart.Series[0].BorderColor = Color.LightBlue;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            BarChart.Titles.Add("Average car speed");
            int count = 1;
            List<int> AVGspeeds = Importer.ImportAVGdailySpeed();
            BarChart.Series["Average speed"].Points.DataBindY(AVGspeeds.ToArray());
            count = count + 1;
        }

        private void fillChartWithAverageSpeed()
        {
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Series.Add("Average speed");
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            BarChart.Series[0].Color = Color.LightSkyBlue;
            BarChart.Series[0].BorderColor = Color.DeepSkyBlue;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            BarChart.Titles.Add("Average speed & amount of cars");
            BarChart.Titles
            int count = 1;
            
            List<int> AVGspeeds = Importer.ImportAVGdailySpeed();
            foreach (var item in AVGspeeds)
            {
                BarChart.Series["Average speed"].Points.AddXY(count, item);
                count = count + 1;
            }

            BarChart.Series.Add("Average car amount");
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            BarChart.Series[1].Color = Color.Gray;
            BarChart.Series[1].BorderColor = Color.DarkGray;
            count = 1;

            List<int> AVGcars = Importer.ImportAVGCarsAmount();
            foreach (var item in AVGcars)
            {
                BarChart.Series["Average car amount"].Points.AddXY(count, item);
                count = count + 1;
            }

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
            fillChartWithAverageSpeed();
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Series.Add("Mijlpaal 1");
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            BarChart.Series[0].Color = Color.Gray;
            BarChart.Series[0].BorderColor = Color.LightBlue;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            BarChart.Titles.Add("Average speed at different locations");
            int count = 1;

            List<_2ValueNodes> ValueNodes = Importer.Import2CarAverage();

            foreach (_2ValueNodes item in ValueNodes)
            {
                BarChart.Series["Mijlpaal 1"].Points.AddXY(count, item.getData1());
                count = count + 1;
            }

            BarChart.Series.Add("Mijlpaal 2");
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line ;

            count = 1;
            foreach (_2ValueNodes item in ValueNodes)
            {
                BarChart.Series["Mijlpaal 2"].Points.AddXY(count, item.getData2());
                count = count + 1;
            }
        }

        private void btnTempCar_Click(object sender, EventArgs e)
        {
            BarChart.Series.Clear();
            BarChart.Titles.Clear();
            BarChart.Series.Add("Average temperature");
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            BarChart.Series[0].Color = Color.Gray;
            BarChart.Series[0].BorderColor = Color.LightBlue;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            BarChart.Titles.Add("Temperature & amount of cars");
            int count = 1;

            List<_2ValueNodes> ValueNodes = Importer.ImportWeatherAndCars();

            foreach (_2ValueNodes item in ValueNodes)
            {
                BarChart.Series["Average temperature"].Points.AddXY(count, item.getData1());
                count = count + 1;
            }

            BarChart.Series.Add("Average car amount");
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            count = 1;
            foreach (_2ValueNodes item in ValueNodes)
            {
                BarChart.Series["Average car amount"].Points.AddXY(count, item.getData2());
                count = count + 1;
            }
        }
        private void fill_charts(string Title, string dataSource1, string DataSource2, List<_2ValueNodes> List)
        {
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

            foreach (_2ValueNodes item in List)
            {
                BarChart.Series[dataSource1].Points.AddXY(count, item.getData1());
                count = count + 1;
            }

            BarChart.Series.Add(DataSource2);
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            count = 1;
            foreach (_2ValueNodes item in List)
            {
                BarChart.Series[DataSource2].Points.AddXY(count, item.getData2());
                count = count + 1;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
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
            if (BegDay.Text.Length > 0 && EndDay.Text.Length > 0)
            {
                bool text = true;
                foreach (char letter in BegDay.Text)
                {
                    if (!char.IsDigit(letter))
                    {
                        text = false;
                    }
                }
                foreach (char letter in EndDay.Text)
                {
                    if (!char.IsDigit(letter))
                    {
                        text = false;
                    }
                }
                int begin = Int32.Parse(BegDay.Text);
                int end = Int32.Parse(EndDay.Text);

                if (!(0 <= begin) && (begin <= 365) && (0 <= end) && (end <= 365)) { text = false; }
                if (text == true)
                {
                    

                    filter filter = new filter(begin, end);
                    BarChart.DataManipulator.Filter(filter, BarChart.Series[0]);
                    BarChart.DataManipulator.Filter(filter, BarChart.Series[1]);
                }else
                {
                    MessageBox.Show("The given filter is not correct");
                }
            }
        }
    }

    public class filter : IDataPointFilter
    {
        int beg = 0;
        int end = 365;
        public filter (int beginning, int ending)
        {
            this.beg = beginning;
            this.end = ending;
        }
        public bool FilterDataPoint(DataPoint point, Series series, Int32 filter_on)
        {
            if ((point.XValue< beg)|| (point.XValue > end))
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
