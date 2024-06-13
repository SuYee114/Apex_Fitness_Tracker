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
    public partial class frmUserGoal : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_GoalTableAdapter objUserGoal = new Apex_Fitness_TrackerDataSetTableAdapters.User_GoalTableAdapter();
        DataTable dtUser = new DataTable();
        public string GoalID;
        public frmUserGoal()
        {
            InitializeComponent();
            GoalID_increment();
        }
       

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value < DateTime.Now)
            {
                MessageBox.Show("Please set the end date again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpEndDate.Focus();
                return;
            }
            DateTime StartDate, EndDate;
            TimeSpan difference;
            StartDate = dtpStartDate.Value;
            EndDate = dtpEndDate.Value;
            difference = EndDate - StartDate;
            lblDuration.Text = difference.Days.ToString();
            // To only show date in Duration text box

        }

        private void lblName_Click(object sender, EventArgs e)
        {
            contextMenuStripName.Show(lblName, 1, lblName.Height);
        }

        private void frmUserGoal_Load(object sender, EventArgs e)
        {
            lblName.Text = frmUserLogIn.UserFirstName[0].ToString();
            ShowUserName.Text = frmUserLogIn.UserFirstName;
            ShowUserID.Text = frmUserLogIn.UserID;
           
        }
        public void GoalID_increment()
        {
            DataTable dt = new DataTable();
            dt = objUserGoal.GetData();
            if (dt.Rows.Count == 0)
            {
                GoalID = "G_001";
                return;
            }
            else
            {
                int size = dt.Rows.Count - 1;// To get the last ID from UserGoal Table
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(2, 3));// To break the G_ part out to calculate ID increment
                if (newID >= 1 && newID < 9)
               {
                    GoalID = "G_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                  GoalID = "G_0" + (newID + 1);
                }
               else if (newID >= 99 && newID < 999)
                {
                    GoalID = "G_" + (newID + 1);
               }
              else
               {
                   GoalID = "Full Limit";
               }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                GoalID_increment();
                DataTable dtcount = new DataTable();
                dtcount = objUserGoal.GetDataByUserID(ShowUserID.Text);
                if (dtcount.Rows.Count > 0)
                {
                    //To handle duplicate goal error
                    DialogResult result = MessageBox.Show("You already have a goal set. \nDo you want to set new goal?", "Existing Goal", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        // Delete current user goal
                        objUserGoal.DeleteGoal(ShowUserID.Text);
                        // Reset form
                        txtCurrentWeight.Clear();
                        txtTargetCalBurn.Clear();
                        dtpStartDate.Value = DateTime.Now;
                        dtpEndDate.Value = DateTime.Now;
                        lblDuration.Text = "0";

                    }
                    return;
                }
                if (lblDuration.Text == "0")//for new goal load
                {
                    MessageBox.Show("Please select End Date again", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCurrentWeight.Text) || txtCurrentWeight.Text == "0")
                {
                    MessageBox.Show("Please Fill your current weight!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTargetCalBurn.Text) || txtTargetCalBurn.Text == "0")
                {
                    MessageBox.Show("Please Fill target calories burn you want to lose!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int duration = int.Parse(lblDuration.Text);
                int targetCalBurn = int.Parse(txtTargetCalBurn.Text);

                if (duration >= 1 && duration <= 7)
                {
                    int maxCalBurn = duration * 2000; // Max caloric goal is 2000 calories per day for 1-7 days
                    if (targetCalBurn > maxCalBurn)
                    {
                        MessageBox.Show("Invalid weight", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (duration > 7 && duration <= 30)
                {
                    int maxCalBurn = 7000 + (duration - 7) * 2000; // Max caloric goal is 7000 calories for 7 days, and an additional 2000 calories per day for each day over 7 days
                    if (targetCalBurn > maxCalBurn)
                    {
                        MessageBox.Show("Invalid weight", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (duration > 30)
                {
                    int maxCalBurn = 140000 + (duration - 30) * 2000; // Max caloric goal is 140000 calories for 30 days
                    if (targetCalBurn > maxCalBurn)
                    {
                        MessageBox.Show("Invalid weight", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int goaldata = objUserGoal.InsertUserGoal(GoalID,
                    ShowUserID.Text,
                    Convert.ToString(dtpStartDate.Value),
                    Convert.ToString(dtpEndDate.Value),
                    Convert.ToInt32(lblDuration.Text),
                    Convert.ToInt32(txtCurrentWeight.Text),
                    Convert.ToInt32(txtTargetCalBurn.Text));
                if (goaldata > 0)
                {
                    MessageBox.Show("You has successfully set Target Goal.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (FormatException)// for alphabetical input handling
            {
                MessageBox.Show("Please only fill as numerical value for each data", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUserHome Home = new frmUserHome();
            Home.Show();
        }
    }
}
