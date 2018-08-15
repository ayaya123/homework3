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
    public partial class circleForm : Form
    {
        public circleForm()
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
            Form5 Form = new Form5();
            double radius = double.Parse(textBox1.Text);
            Form.label1.Text= calcCircleArea(radius).ToString();
            Form.Show();
        }

        private double calcCircleArea(double radius)
        {
            double area = 3.1415926 * radius * radius;
            return area;
        }
    }
}
