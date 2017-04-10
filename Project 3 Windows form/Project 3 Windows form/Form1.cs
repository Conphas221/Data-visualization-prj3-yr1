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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> test = Importer.ImportSpeeds();
            int everything = 0;
            Result.Text = everything.ToString();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to convert the speeds?","convert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Converter convert = new Converter();
                convert.ConvertDatabaseToNewList();
            }

        }
        private void fillChartWithAverageSpeed()
        {
            BarChart.Series.Clear();
            List<int> AVGspeeds = Importer.ImportAVGdailySpeed();
            foreach (var item in Importer.ImportAVGdailySpeed())
            {
                BarChart.Series["gemSnelheid"].Points.AddXY("", "85");
            }
            
        }
    }
}
