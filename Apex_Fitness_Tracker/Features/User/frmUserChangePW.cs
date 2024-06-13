using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex_Fitness_Tracker.Features.User
{
    public partial class frmUserChangePW : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter objChangePW = new Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter();
        DataTable dt = new DataTable();
        public frmUserChangePW()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserHome Home = new frmUserHome();
            Home.Show();
        }
        private bool Validation()
        {
            string Newpassword = txtNewPW.Text;
            if (txtOldPW.Text == "")
            {
                MessageBox.Show("Please Enter your old password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPW.Focus();
                return false;
            }

            if (txtNewPW.Text == "")
            {
                MessageBox.Show("Please Enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPW.Focus();
                return false;
            }

            if (!Newpassword.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least One upper one character", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPW.Focus();
                return false;
            }

            if (!Newpassword.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least One lower characters", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPW.Focus();
                return false;
            }

            if (!Newpassword.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least One digit", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPW.Focus();
                return false;
            }

            if (txtNewPW.Text.Length < 12)
            {
                MessageBox.Show("Password must be exactly 12 character", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPW.Focus();
                return false;
            }

            if (txtConfirmPW.Text == "")
            {
                MessageBox.Show("Plaese Enter your password to confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPW.Focus();
                return false;
            }

            if (txtNewPW.Text != txtConfirmPW.Text)
            {
                MessageBox.Show("Plaese ReEnter Password to Confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPW.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            string oldpassword, newpassword, confirmpassword;
            oldpassword = txtOldPW.Text;
            newpassword = txtNewPW.Text;
            confirmpassword = txtConfirmPW.Text;
            dt=objChangePW.CheckPassword(oldpassword);
            if (dt.Rows.Count > 0)
            {
                int data = objChangePW.UpdatePassword(newpassword, confirmpassword, ShowUserID.Text);
                if (data > 0)
                {
                    MessageBox.Show(" Your password is successfully updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(" Incorrect Old Password ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmUserChangePW_Load(object sender, EventArgs e)
        {
            btnName.Text = frmUserLogIn.UserFirstName[0].ToString();
            ShowUserID.Text = frmUserLogIn.UserID;
            ShowUserName.Text = frmUserLogIn.UserFirstName;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            contextMenuStripName.Show(btnName, 1, btnName.Height);
        }

    }
}
