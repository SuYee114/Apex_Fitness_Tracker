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
    public partial class frmManagerReport : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_ReportTableAdapter ManagerReport = new Apex_Fitness_TrackerDataSetTableAdapters.User_ReportTableAdapter();
        DataTable dtMreport = new DataTable();
        public frmManagerReport()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {
             contextMenuStripName.Show(btnName, 1, btnName.Height);
        }

        private void frmManagerReport_Load(object sender, EventArgs e)
        {
            btnName.Text = frmManagerLogIn.ManagerFirstName[0].ToString();
            ShowName.Text = frmManagerLogIn.ManagerFirstName;
            ShowID.Text = frmManagerLogIn.ManagerID;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dtMreport = ManagerReport.ReportbyManager();
            dgvManagerReport.DataSource = dtMreport;
            DataView dv = dtMreport.DefaultView;
            dv.RowFilter = "UserID LIKE '" + txtUserID.Text + "%'";
            dgvManagerReport.DataSource = dv;
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            dtMreport = ManagerReport.ReportbyManager();
            dgvManagerReport.DataSource = dtMreport;
            dgvManagerReport.Refresh();
        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmManagerHome Home = new frmManagerHome();
            Home.Show();
        }
    }
}
