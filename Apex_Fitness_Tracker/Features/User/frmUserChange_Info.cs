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
    public partial class frmUserChange_Info : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter objInfo_Edit = new Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter();

        public frmUserChange_Info()
        {
            InitializeComponent();
            lblName.Text = frmUserLogIn.UserFirstName[0].ToString();
            ShowUserID.Text = frmUserLogIn.UserID;
            ShowUserName.Text = frmUserLogIn.UserFirstName;
        }

        private void frmUserChange_Info_Load(object sender, EventArgs e)
        {
            // retrieve the user data from Registeration form
            DataTable dtEdit = new DataTable();
            dtEdit = objInfo_Edit.GetData_4_UserEdit(ShowUserID.Text);
            if (dtEdit.Rows.Count > 0)
            {
                txtFname.Text = dtEdit.Rows[0]["UserFname"].ToString();
                txtLname.Text = dtEdit.Rows[0]["UserLname"].ToString();
                txtPhNum.Text = dtEdit.Rows[0]["UserPhNum"].ToString();
                txtEmail.Text = dtEdit.Rows[0]["UserEmail"].ToString();
            }

        }

        private void lblName_Click(object sender, EventArgs e)
        {
            contextMenuStripName.Show(lblName, 1, lblName.Height);
        }
        private bool IsGmailAddress(string email)//To avoid invalid email
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFname.Text))
                {
                    MessageBox.Show("Please fill the first name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFname.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtLname.Text))
                {
                    MessageBox.Show("Please fill the last name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLname.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPhNum.Text))
                {
                    MessageBox.Show("Please fill the phone number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhNum.Focus();
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhNum.Text, @"^\d{11}$"))
                {
                    MessageBox.Show("Phone Number must be exactly 11 digits long numbers", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhNum.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please fill the email", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
                if (!IsGmailAddress(txtEmail.Text))
                {
                    MessageBox.Show("Please Enter a valid email address", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    int data = objInfo_Edit.UpdateUserInfo(txtFname.Text, txtLname.Text, txtPhNum.Text, txtEmail.Text, ShowUserID.Text);
                    if (data > 0)
                    {
                        MessageBox.Show("Your profile information is successfully updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please try again");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserHome Home = new frmUserHome();
            Home.Show();
        }
    }
}
