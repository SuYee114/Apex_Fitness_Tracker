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

namespace Apex_Fitness_Tracker.Features.User
{
    public partial class frmFirstIntro : Form
    {
        public frmFirstIntro()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserLogIn UserEnter = new frmUserLogIn();
            UserEnter.Show();
        }

        private void lnkManagerEnter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAccessWall ManagerEnter = new frmAccessWall();
            ManagerEnter.Show();
        }
    }
}
