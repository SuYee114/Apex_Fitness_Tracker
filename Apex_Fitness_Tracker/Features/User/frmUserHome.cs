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
    public partial class frmUserHome : Form
    {
        public frmUserHome()
        {
            InitializeComponent();
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact US: support@apexfitness.com", " Help ", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            contextMenuStripName.Show(lblName, 1, lblName.Height);
        }

        private void frmUserHome_Load(object sender, EventArgs e)
        {
            lblName.Text = frmUserLogIn.UserFirstName[0].ToString();
            ShowName.Text = frmUserLogIn.UserFirstName;
            ShowID.Text = frmUserLogIn.UserID;
        }

        private void lblGoal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserGoal goal = new frmUserGoal();
            goal.Show();
        }

        private void lblActivities_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserActivities Act = new frmUserActivities();
            Act.Show();
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserProgressReport objProgress = new frmUserProgressReport();
            objProgress.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserLogIn Login = new frmUserLogIn();
            Login.Show();
        }

        private void mnuChangeInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserChangePW ChangePW = new frmUserChangePW();
            ChangePW.Show();
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            contextMenuStripProfile.Show(lblProfile, 1, lblProfile.Height);
        }

        private void mnuChangePW_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserChange_Info Info_Edit = new frmUserChange_Info();
            Info_Edit.Show();

        }
    }
}
