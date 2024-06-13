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
    public partial class frmAccessWall : Form
    {
        public frmAccessWall()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccessKey.Text))
            {
                MessageBox.Show("Please fill the Manager access key!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string correctAccessKey = "2KLYMEE$GP";//For Security and to avoid user accidently entering Manager access

                if (txtAccessKey.Text == correctAccessKey)
                {
                    MessageBox.Show("Welcome Manager!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmManagerLogIn ManagerEnter = new frmManagerLogIn();
                    ManagerEnter.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Access Key", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
