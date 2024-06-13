using Apex_Fitness_Tracker.Features.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex_Fitness_Tracker
{
    public partial class frmManagerLogIn : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.Manager_SignUpTableAdapter objManagerLogIn = new Apex_Fitness_TrackerDataSetTableAdapters.Manager_SignUpTableAdapter();
        private int LogAttemptCount = 0;
        public static string ManagerID, ManagerFirstName;

        public frmManagerLogIn()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lnkManagerRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmManagerRegisteration Register = new frmManagerRegisteration();
            Register.SetGpboxEditVisible(false);
            //To make manager is invisible to Registration form's dgv before registeration to prevent isser later, dgv can only seen in entering through Manager Home page button for monitering,update and delete info
            Register.Show();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            if (LogAttemptCount == 5)
            {
                MessageBox.Show(" LogIn failed: You have reached the limited login attempt! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);//5 LogIn Attempt Limit
                return;
            }
            if (txtManagerfName.Text == "")
            {
                MessageBox.Show(" Please fill your first name! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtManagerPW.Text == "")
            {
                MessageBox.Show(" Please fill your password! ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataTable dtManager = new DataTable();
                dtManager = objManagerLogIn.ManagerLogIn(txtManagerfName.Text, txtManagerPW.Text);
                if (dtManager.Rows.Count == 1)
                {
                    MessageBox.Show("Login successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLogIn.DataSource = dtManager;
                    ManagerID = dgvLogIn[0, 0].Value.ToString();
                    ManagerFirstName = dgvLogIn[1, 0].Value.ToString();
                    frmManagerHome home = new frmManagerHome();
                    home.Show();
                    this.Hide();


                }
                else
                {
                    LogAttemptCount += 1;
                    if (LogAttemptCount < 6)
                    {
                        MessageBox.Show(" LogIn Attempt " + LogAttemptCount + ": " + "Incorrect password or phone number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void lnkManagerforgetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmManagerforgetPW forgetPW = new frmManagerforgetPW();
            forgetPW.Show();
        }
    }
}
