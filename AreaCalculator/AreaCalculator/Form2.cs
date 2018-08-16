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
            //if (string.IsNullOrEmpty(cordX.Text) || string.IsNullOrEmpty(cordY.Text))
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form = new Form4();

            LastX = NowX;
            LastY = NowY;
            NowX = double.Parse(cordX.Text);
            NowY = double.Parse(cordY.Text);

            Form.label1.Text = Math.Abs(Area + 0.5 * detCalc(LastX, LastY, NowX, NowY) + 0.5 * detCalc(NowX, NowY, IniX, IniY)).ToString() + " " + (count + 1).ToString();
            Form.Show();
        }

        private double detCalc(double detA, double detB, double detC, double detD)
        {
            return detA * detD - detB * detC;
        }
    }
}
