using Apex_Fitness_Tracker.Features.User;
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
    public partial class frmManagerHome : Form
    {
        public frmManagerHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            contextMenuStripProfile.Show(lblProfile, 1, lblProfile.Height);

        }

        private void mnuManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerRegisteration ManagerProfile = new frmManagerRegisteration();
            ManagerProfile.SetGpboxEditVisible(true);
            ManagerProfile.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerLogIn Logout = new frmManagerLogIn();
            Logout.Show();
        }

        private void frmManagerHome_Load(object sender, EventArgs e)
        {
            lblName.Text = frmManagerLogIn.ManagerFirstName[0].ToString();
            ShowName.Text = frmManagerLogIn.ManagerFirstName;
            ShowID.Text = frmManagerLogIn.ManagerID;
           
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            contextMenuStripName.Show(lblName, 1, lblName.Height);
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerReport Mreport = new frmManagerReport();
            Mreport.Show();
        }

        private void lblBMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerBMI_Calculator BMI = new frmManagerBMI_Calculator();
            BMI.Show();
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserRegister URegister = new frmUserRegister();
            URegister.Show();
        }

       
    }
}
