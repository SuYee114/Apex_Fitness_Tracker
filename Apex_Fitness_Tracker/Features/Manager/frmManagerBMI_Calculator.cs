using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex_Fitness_Tracker.Features.Manager
{
    public partial class frmManagerBMI_Calculator : Form
    {
        public frmManagerBMI_Calculator()
        {
            InitializeComponent();
        }
        string status;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Please fill the weight", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Please fill the height", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
                return;
            }
            else
            {
                double weight = Convert.ToDouble(txtWeight.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                double result = weight / ((height/100) * (height/100));
                //convert cm to m and then double those meter and divide with weight
                if (result < 18.5)
                {
                    status = "You are underweight";
                }
                else if(result < 25)
                {
                    status = "You have normal weight";//normal weight= 18.5-24.9
                }
                else if (result < 30)//25-29.9 is overweight
                {
                    status = "You are overweight";
                }
                else if (result >= 30)
                {
                    status = "You are obese";
                }
                lblResult.Text = "Your BMI is: " + result.ToString("N1") + "\r\n" + status;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerHome Home = new frmManagerHome();
            Home.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Text = " ";
            txtHeight.Text = " ";
            lblResult.Text = " ";
        }
    }
}
