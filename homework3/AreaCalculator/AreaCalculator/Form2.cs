using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class polygonForm : Form
    {
        public polygonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm Form = new mainForm();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 Form = new Form6();
            double x1 = double.Parse(cordX.Text);
            double y1 = double.Parse(cordY.Text);
            double x2 = double.Parse(textBox2.Text);
            double y2 = double.Parse(textBox1.Text);
            double x3 = double.Parse(textBox4.Text);
            double y3 = double.Parse(textBox3.Text);
            double x4 = double.Parse(textBox6.Text);
            double y4 = double.Parse(textBox5.Text);
            double x5 = double.Parse(textBox8.Text);
            double y5 = double.Parse(textBox7.Text);
            Form.label2.Text = System.Math.Abs(calcPolygonArea(x1,y1,x2,y2,x3,y3,x4,y4,x5,y5)).ToString();
            Form.Show();
        }

        private double calcPolygonArea(double x1,double y1, double x2, double y2, double x3, double y3, double x4, double y4, double x5, double y5)
        {
            double areaPolygon = x1 * y2 - x2 * y1 + x2 * y3 - x3 * y2 + x3 * y4 - x4 * y3 + x4 * y5 - x5 * y4 + x5 * y1 - x1 * y5;
            areaPolygon = 0.5 * areaPolygon;
            return areaPolygon;
        }

        private void cordX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
