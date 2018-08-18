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
                    //polygonForm Form = new polygonForm(true);
                    //Form.Show();
                    PolyFormation(radioButton3.Checked);
                }
                if (radioButton4.Checked == true)
                {
                    //polygonForm Form = new polygonForm(false);
                    //Form.Show();
                    PolyFormation(radioButton3.Checked);
                }
            }
            else if (radioButton2.Checked == true)
            {
                this.Hide();
                if (radioButton3.Checked == true)
                {
                    //circleForm Form = new circleForm(true);
                    //Form.Show();
                    CircFormation(radioButton3.Checked);
                }
                if (radioButton4.Checked == true)
                {
                    //circleForm Form = new circleForm(false);
                    //Form.Show();
                    CircFormation(radioButton3.Checked);
                }
            }
        }

        private void PolyFormation(bool CenSelected)
        {
            polygonForm Form = new polygonForm(CenSelected);
            Form.Show();
        }

        private void CircFormation(bool CenSelected)
        {
            circleForm Form = new circleForm(CenSelected);
            Form.Show();
        }

        public static void ShowMainForm()
        {
            mainForm Form = new mainForm();
            Form.Show();
        }
    }
}
