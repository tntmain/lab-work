using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
        }
        private double[,] Coords;
        public void ReadFile(string file)
        {
            Coords = new double[15, 2];
            var sr = new StreamReader(file);
            string line;
            int point = 0;
            int ser = 1;

            while ((line = sr.ReadLine()) != null)
            {
                string[] splittine = line.Split(' ');
                Coords[point, 0] = Convert.ToDouble(splittine[0]);
                Coords[point, 1] = Convert.ToDouble(splittine[1]);

                if (point % 5 == 0)
                {
                    string NameSerie = "Серия" + Convert.ToString(ser);
                    checkedListBox1.Items.Add(NameSerie);
                    ser++;
                }
                point++;
            }
        }
        public void CreateSerie(int NumSerie)
        {
            double x, y;
            string NameSerie = "Серия" + Convert.ToString(NumSerie + 1);
            chart1.Series.Add(new Series(NameSerie));
            chart1.Series[NameSerie].ChartType = SeriesChartType.Spline;
            chart1.Series[NameSerie].Enabled = true;
            chart1.Series[NameSerie].BorderWidth = 2;

            for (int p = 0; p < 5; p++)
            {
                x = Coords[p + NumSerie * 5, 0];
                y = Coords[p + NumSerie * 5, 1];
                chart1.Series[NameSerie].Points.AddXY(x, y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.txt)|*.txt" };
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            filename = openFileDialog1.FileName;
            ReadFile(filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    CreateSerie(i);
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int var = comboBox1.SelectedIndex;
            if (var == 1) var = 3;
            else
            if (var == 2) var = 4;

            foreach (Series ser in chart1.Series)
            {
                ser.ChartType = (SeriesChartType)var;

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point(splitContainer1.Panel1.Width / 2 - 67, splitContainer1.Panel1.Height / 10 + 9);
            checkedListBox1.Location = new Point(splitContainer1.Panel1.Width / 2 - 62, splitContainer1.Panel1.Height / 5 - 8);
            checkedListBox1.Height = splitContainer1.Panel1.Height / 2;
            label2.Location = new Point(splitContainer1.Panel1.Width / 2 - 60, splitContainer1.Panel1.Height - splitContainer1.Panel1.Height / 5 + 33);
            comboBox1.Location = new Point(splitContainer1.Panel1.Width / 2 - 60, splitContainer1.Panel1.Height - splitContainer1.Panel1.Height / 5 + 55);


            button1.Location = new Point(splitContainer1.Panel1.Width / 2 - 62, splitContainer1.Panel1.Height / 20 - 8);
            button2.Location = new Point(splitContainer1.Panel1.Width / 2 - 62, splitContainer1.Panel1.Height - splitContainer1.Panel1.Height / 4 - 30);
            button3.Location = new Point(splitContainer1.Panel1.Width / 2 - 62, splitContainer1.Panel1.Height - splitContainer1.Panel1.Height / 4 - 10);
            button4.Location = new Point(splitContainer1.Panel1.Width / 2 - 62, splitContainer1.Panel1.Height - splitContainer1.Panel1.Height / 4 + 10);
        }

        public void CreateSeries()
        {
            chart1.Series.Clear();
            Series seriesX = new Series("Отрицательные X");
            Series seriesY = new Series("Отрицательные Y");
            Series seriesBoth = new Series("Отрицательные X и Y");

            seriesX.ChartType = SeriesChartType.Point;
            seriesY.ChartType = SeriesChartType.Point;
            seriesBoth.ChartType = SeriesChartType.Point;

            for (int i = 0; i < Coords.GetLength(0); i++)
            {
                double x = Coords[i, 0];
                double y = Coords[i, 1];

                if (x < 0 && y < 0)
                {
                    seriesBoth.Points.AddXY(x, y);
                }
                else if (x < 0)
                {
                    seriesX.Points.AddXY(x, y);
                }
                else if (y < 0)
                {
                    seriesY.Points.AddXY(x, y);
                }
            }

            chart1.Series.Add(seriesX);
            chart1.Series.Add(seriesY);
            chart1.Series.Add(seriesBoth);
        }

        public void ReadCoordinatesFromFiles(string xFile, string yFile)
        {
            Coords = new double[15, 2];
            var xLines = File.ReadAllLines(xFile);
            var yLines = File.ReadAllLines(yFile);

            for (int i = 0; i < xLines.Length; i++)
            {
                Coords[i, 0] = Convert.ToDouble(xLines[i]);
                Coords[i, 1] = Convert.ToDouble(yLines[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string xFile, yFile;
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Текстовые файлы(*.txt)|*.txt" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xFile = openFileDialog1.FileName;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    yFile = openFileDialog1.FileName;
                    ReadCoordinatesFromFiles(xFile, yFile);
                    CreateSeries();
                }
            }
        }

        public void PlotTrigonometricFunction()
        {
            Series series = new Series("Sin(x)");
            series.ChartType = SeriesChartType.Line;

            for (double x = -10; x <= 10; x += 0.1)
            {
                double y = Math.Sin(x);
                series.Points.AddXY(x, y);
            }

            chart1.Series.Clear();
            chart1.Series.Add(series);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlotTrigonometricFunction();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}