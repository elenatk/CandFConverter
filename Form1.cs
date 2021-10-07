using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandFConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputeF_Click(object sender, EventArgs e)
        {
            try
            {
                double  N = double.Parse(txtNumber.Text);
                
                //calculate F
                double F = (9/5*N + 32);
                
                //display result
                lblResult.Text = "C to F:  " + F;
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComputeC_Click(object sender, EventArgs e)
        {
            try
            {
                double N = double.Parse(txtNumber.Text);

                //calculate C
                double C = (9 / 5 *(N - 32));

                //display result
                lblResult.Text = "F to C: " + C;
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
