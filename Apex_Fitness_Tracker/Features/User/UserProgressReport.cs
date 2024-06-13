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
    public partial class frmUserProgressReport : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_ReportTableAdapter Report = new Apex_Fitness_TrackerDataSetTableAdapters.User_ReportTableAdapter();
        DataTable dt = new DataTable();
        public frmUserProgressReport()
        {
            InitializeComponent();
        }

        private void frmUserProgressReport_Load(object sender, EventArgs e)
        {
            lblName.Text = frmUserLogIn.UserFirstName[0].ToString();
            ShowUserID.Text = frmUserLogIn.UserID;
            ShowUserName.Text = frmUserLogIn.UserFirstName;
            dt = Report.FillReport(ShowUserID.Text);
            if (dt.Rows.Count > 0)
            {
                string Total_CaloriesBurned = dt.Rows[0][2].ToString();
                string Total_ActCount = dt.Rows[0][3].ToString();
                string Total_ActDuration = dt.Rows[0][4].ToString();
                string Percent = dt.Rows[0][5].ToString();
                lblCalBurnPercent.Text = "You have acheived " + Percent + "% of your target goal!";
                lblCalBurnTotal.Text = Total_CaloriesBurned+" cal";
                lblTotalActCount.Text = Total_ActCount;
                lblTotalActDuration.Text = Total_ActDuration+" min";
            }
            else
            {
                //for user with no activity and no data
                lblName.Text = frmUserLogIn.UserFirstName[0].ToString();
                ShowUserID.Text = frmUserLogIn.UserID;
                ShowUserName.Text = frmUserLogIn.UserFirstName;

                lblCalBurnPercent.Text = "You have acheived " + "0.0" + " % of your target goal!";
                lblCalBurnTotal.Text = "0.0" + " cal";
                lblTotalActCount.Text = "0";
                lblTotalActDuration.Text = "0.0" + " min";
                
                
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserHome Home = new frmUserHome();
            Home.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            contextMenuStripName.Show(lblName, 1, lblName.Height);
        }
    }
}
