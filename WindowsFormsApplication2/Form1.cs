using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            double j = 0.0d;
            float k = 0.1f;

          

            string strTest;

           
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].ChartType = SeriesChartType.Line;
          


            chart1.Series[0].Name = "Test";
            chart1.Series[0].Points.AddXY(2006, 10);
            chart1.Series[0].Points.AddXY(2007, 25);
            chart1.Series[0].Points.AddXY(2008, 75);
            chart1.Series[0].Points.AddXY(2009, 110);
            chart1.Series[0].Points.AddXY(2010, 130);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Name = "Test";
            chart1.Series[0].Points.AddXY(2006, 10);
            chart1.Series[0].Points.AddXY(2007, 25);
            chart1.Series[0].Points.AddXY(2008, 75);
            chart1.Series[0].Points.AddXY(2009, 110);
            chart1.Series[0].Points.AddXY(2010, 130);

            chart1.Series.Add("Test2");

            chart1.Series[1].Points.AddXY(2006, 150);
            chart1.Series[1].Points.AddXY(2007, 75);
            chart1.Series[1].Points.AddXY(2008, 25);
            chart1.Series[1].Points.AddXY(2009, 10);
            chart1.Series[1].Points.AddXY(2010, 15);  

            // new point

            chart1.Series[1].Points.AddXY(2012, 17);  
        }
    }
}
