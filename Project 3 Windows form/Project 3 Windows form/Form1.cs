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
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            BarChart.Series[0].Color = Color.Gray;
            BarChart.Series[0].BorderColor = Color.LightBlue;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            BarChart.Titles.Add("average car speed");
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
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            BarChart.Series[0].Color = Color.Red;
            BarChart.Series[0].BorderColor = Color.Red;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            BarChart.Titles.Add("Average speed & amount of cars");
            int count = 1;
            
            List<int> AVGspeeds = Importer.ImportAVGdailySpeed();
            foreach (var item in AVGspeeds)
            {
                BarChart.Series["Average speed"].Points.AddXY(count, item);
                count = count + 1;
            }

            BarChart.Series.Add("Average car amount");
            BarChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
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
            BarChart.Series[0].Color = Color.DarkSlateGray;
            BarChart.Series[0].BorderColor = Color.LightBlue;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            BarChart.Titles.Add("average speed at different locations");
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
            BarChart.Series.Add("Average Temperature");
            BarChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            BarChart.Series[0].Color = Color.MediumSeaGreen;
            BarChart.Series[0].BorderColor = Color.SpringGreen;
            BarChart.BackColor = Color.WhiteSmoke;
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            BarChart.Titles.Add("Weather & amount of cars");
            int count = 1;

            List<_2ValueNodes> ValueNodes = Importer.ImportWeatherAndCars();

            foreach (_2ValueNodes item in ValueNodes)
            {
                BarChart.Series["Average Temperature"].Points.AddXY(count, item.getData1());
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
    }
}
