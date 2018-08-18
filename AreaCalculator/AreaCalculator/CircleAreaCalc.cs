using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class CircleAreaCalc
    {
        public static void ResultOutput(string Text,bool UnitCheck)
        {
            Form5 Form = new Form5();
            if (string.IsNullOrEmpty(Text))
            {
                Form.label1.Text = "输入不能为空";
            }
            else
            {
                double radius = double.Parse(Text);
                if (UnitCheck)
                {
                    Form.label1.Text = "面积是" + calcCircleArea(radius).ToString("F3") + "平方厘米";
                }
                else
                {
                    Form.label1.Text = "面积是" + (6.4156 * calcCircleArea(radius)).ToString("F3") + "平方厘米";
                }
            }

            Form.Show();
        }
        public static double calcCircleArea(double radius)
        {
            double area = 3.1415926 * radius * radius;
            return area;
        }
    }
}
