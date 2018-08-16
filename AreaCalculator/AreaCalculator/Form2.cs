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

        private int count=0;
        private double LastX = 0, LastY = 0, NowX = 0, NowY = 0, Area = 0, IniX = 0, IniY = 0;

        public polygonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm Form0 = new mainForm();
            Form0.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cordX.Text) || string.IsNullOrEmpty(cordY.Text))
            {
                Form4 Form = new Form4();
                Form.label1.Text = "输入不能为空";
                Form.label2.Text = "";
                Form.Show();
            }
            else
            {
                count = count + 1;

                LastX = NowX;
                LastY = NowY;
                NowX = double.Parse(cordX.Text);
                NowY = double.Parse(cordY.Text);

                Area = Area + 0.5 * detCalc(LastX, LastY, NowX, NowY);

                if (count == 1)
                {
                    IniX = NowX;
                    IniY = NowY;
                }
            }
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form = new Form4();

            LastX = NowX;
            LastY = NowY;
            NowX = double.Parse(cordX.Text);
            NowY = double.Parse(cordY.Text);

            if (count >= 3)
            {
                Form.label1.Text = "面积为：" + Math.Abs(Area + 0.5 * detCalc(LastX, LastY, NowX, NowY) + 0.5 * detCalc(NowX, NowY, IniX, IniY)).ToString("F3");
                Form.label2.Text = "是" + (count + 1).ToString() + "边形";
            }
            else if (count == 2)
            {
                Form.label1.Text = "面积为：" + Math.Abs(Area + 0.5 * detCalc(LastX, LastY, NowX, NowY) + 0.5 * detCalc(NowX, NowY, IniX, IniY)).ToString("F3");
                Form.label2.Text = "是三角形";
            }
            else
            {
                Form.label1.Text = "请输入三个及以上顶点";
                Form.label2.Text = "";
            }
            Form.Show();
        }

        private double detCalc(double detA, double detB, double detC, double detD)
        {
            return detA * detD - detB * detC;
        }
    }
}
