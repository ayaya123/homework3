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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.Hide();
                if (radioButton3.Checked == true)
                {
                    polygonForm Form = new polygonForm(true);
                    Form.Show();
                }
                if (radioButton4.Checked == true)
                {
                    polygonForm Form = new polygonForm(false);
                    Form.Show();
                }
            }
            else if (radioButton2.Checked == true)
            {
                this.Hide();
                if (radioButton3.Checked == true)
                {
                    circleForm Form = new circleForm(true);
                    Form.Show();
                }
                if (radioButton4.Checked == true)
                {
                    circleForm Form = new circleForm(false);
                    Form.Show();
                }
            }
        }
    }
}
