using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * NAME - JASKIRAT KAUR
 * STUDENT NO - 301107505
 * DATE - 05 AUG 2020
 * DESCRIPTION - BMI CALCULATOR
 */

namespace Assignment4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashformtimer_Tick(object sender, EventArgs e)
        {
            Program.bmiCalculator.Show();
            this.Hide();
            splashformtimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
