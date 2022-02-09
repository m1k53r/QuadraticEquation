using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GeneratePoints();
        }

        private readonly double[] points = new double[3] { 0, 0, 0 };
        private int res = 1;
        private enum Inputs
        {
            aValue,
            bValue,
            cValue
        }
        private void Trigger(object sender, EventArgs e)
        {
            if (sender is TextBox input)
            {
                _ = Enum.TryParse(input.Name, out Inputs index);
                _ = double.TryParse(input.Text, out points[(int)index]);
            }
            else if (sender is TrackBar trackbar)
            {
                res = (2 * trackbar.Value) - 1;
            }
            GeneratePoints();
        }
        private double Calculate(double x)
        {
            return (points[0] * Math.Pow(x, 2)) + (points[1] * x) + points[2];
        }
        private void GeneratePoints()
        {
            chart1.Series["Wykresik"].Points.Clear();
            for (int i = -res; i < res; i++)
            {
                _ = chart1.Series["Wykresik"].Points.AddXY(i, Calculate(i));
            }
        }
    }
}
