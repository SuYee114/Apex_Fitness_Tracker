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
    public partial class frmUserLogIn : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter objUserLogIn = new Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter();
        private int LogAttemptCount = 0;
        public static string UserID, UserFirstName;

        public frmUserLogIn()
        {
            InitializeComponent();
        }

        private void frmUserLogIn_Load(object sender, EventArgs e)
        {
          
        }

        private void lnkUserExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            if (LogAttemptCount == 5)// 5 login attempt
            {
                MessageBox.Show(" LogIn failed: You have reached the limited login attempt! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUserfName.Text == "")
            {
                MessageBox.Show(" Please fill your first name! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUserPW.Text == "")
            {
                MessageBox.Show(" Please fill your password! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataTable dtUser = new DataTable();
                dtUser = objUserLogIn.UserLogin(txtUserfName.Text, txtUserPW.Text);
                if (dtUser.Rows.Count == 1)
                {
                    MessageBox.Show("Login successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUserLogIn.DataSource = dtUser;
                    UserID = dgvUserLogIn[0, 0].Value.ToString();
                    UserFirstName = dgvUserLogIn[1, 0].Value.ToString();

                    frmUserHome Home = new frmUserHome();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    LogAttemptCount += 1;
                    if (LogAttemptCount < 6)//For attempt more than 5 counter
                    {
                        MessageBox.Show(" LogIn Attempt " + LogAttemptCount + ": " + "Incorrect password or phone number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void lnkUserRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmUserRegister Register = new frmUserRegister();
            Register.SetGpboxEditVisible(false);
            //To make user is invisible to dgv in Registration form, this dgv can only seen in entering through Manager Home page button for monitoring, updating and deleting info
            //User can update these info with text box type not with dgv to make user experience better
            Register.Show();
        }

        private void lnkUserforgetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmUserforgetPW forgetPW = new frmUserforgetPW();
            forgetPW.Show();
        }
    }
}
