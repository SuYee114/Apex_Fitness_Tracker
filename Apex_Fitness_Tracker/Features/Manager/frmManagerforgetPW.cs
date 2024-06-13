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
    public partial class frmManagerforgetPW : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.Manager_SignUpTableAdapter objgetPW = new Apex_Fitness_TrackerDataSetTableAdapters.Manager_SignUpTableAdapter();

        public frmManagerforgetPW()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerLogIn LogIn1 = new frmManagerLogIn();
            LogIn1.Show();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtAccID.Text == "")
            {
                MessageBox.Show("Please Enter Your ID", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Your Email Address.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable table = objgetPW.getForgetPassword(txtAccID.Text, txtEmail.Text);
            // if both email and ID is incorrect 
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No account found", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string password = table.Rows[0]["ManagerPW"].ToString();

                MessageBox.Show("Your password is: " + password, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
