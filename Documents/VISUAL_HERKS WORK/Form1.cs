using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerkulesGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            double english = Convert.ToDouble(txtEnglish.Text);
            double math = Convert.ToDouble(txtMath.Text);
            double science = Convert.ToDouble(txtScience.Text);
            double filipino = Convert.ToDouble(txtFilipino.Text);
            double history = Convert.ToDouble(txtHistory.Text);

            double average = (english + math + science + filipino + history) / 5;

            string name = txtName.Text;

            if (average >= 75)
            {
                lblResult.Text = name + " passed with an average of " + average.ToString("F2");
            }
            else
            {
                lblResult.Text = name + " failed with an average of " + average.ToString("F2");
            }
        }
    }
}
