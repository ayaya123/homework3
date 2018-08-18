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

        bool UnitCheck;

        public circleForm(bool checkedvalue)
        {
            InitializeComponent();
            UnitCheck = checkedvalue;
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
            mainForm Form0 = new mainForm();

            /*if (string.IsNullOrEmpty(textBox1.Text))
            {
                //Form.label1.Text = "输入不能为空";
            }
            else
            {
                double radius = double.Parse(textBox1.Text);
                if (UnitCheck)
                {
                    //Form.label1.Text = "面积是" + calcCircleArea(radius).ToString("F3") + "平方厘米";
                    Form.label1.Text = "面积是" + CircleAreaCalc.calcCircleArea(radius).ToString("F3") + "平方厘米";
                }
                else
                {
                    //Form.label1.Text = "面积是" + (6.4156 * calcCircleArea(radius)).ToString("F3") + "平方厘米";
                    Form.label1.Text = "面积是" + (6.4156 * CircleAreaCalc.calcCircleArea(radius)).ToString("F3") + "平方厘米";
                }
            }*/

            CircleAreaCalc.ResultOutput(textBox1.Text, UnitCheck);

            textBox1.Text = "";

            //Form.Show();
        }

        //private double calcCircleArea(double radius)
        //{
            //double area = 3.1415926 * radius * radius;
            //return area;
        //}
    }
}
