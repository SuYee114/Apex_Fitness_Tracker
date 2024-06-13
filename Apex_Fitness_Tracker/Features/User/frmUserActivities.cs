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
    public partial class frmUserActivities : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_ActivityTableAdapter objAct = new Apex_Fitness_TrackerDataSetTableAdapters.User_ActivityTableAdapter();
        DataTable dtUserAct = new DataTable();

        Apex_Fitness_TrackerDataSetTableAdapters.User_ActInfoTableAdapter objActInfo = new Apex_Fitness_TrackerDataSetTableAdapters.User_ActInfoTableAdapter();

        Apex_Fitness_TrackerDataSetTableAdapters.User_ReportTableAdapter objReport = new Apex_Fitness_TrackerDataSetTableAdapters.User_ReportTableAdapter();

        string activity, ActID, Total_Cal, Total_ActCount, Total_ActDuration, Progress, ReportID;
        double normal, moderate, intense, progress, target, weight,calburn;
        double total_Cal = 0;
        double total_ActDuration = 0;
        int total_ActCount = 0;

        public frmUserActivities()
        {
            InitializeComponent();
            ActivityID_increment();
            ReportID_increment();
            DataTable dtUserAct = new DataTable();                    
         }

        private string GetNextID(string prefix, DataTable table)
        {
            if (table.Rows.Count == 0)
            {
                return prefix + "001";
            }
            else
            {
                int size = table.Rows.Count - 1;// To get the last ID from Table
                string oldID = table.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(2, 3));// To break the prefix part out to calculate ID increment
                if (newID >= 1 && newID < 9)
                {
                    return prefix + "00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    return prefix + "0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    return prefix + (newID + 1);
                }
                else
                {
                    return "Full Limit";
                }
            }
        }

        public void ActivityID_increment()
        {
            ActID = GetNextID("A_", objAct.GetData());
        }

        private void cboactivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // To change MET value and label and metric lable according to the selected activity
            if (cboactivity.SelectedItem == null) return;
            activity = cboactivity.SelectedItem.ToString();
            switch(activity)
            {
                case"Swimming":
                    lblmetric2.Text = "Lap Count:";
                    label8.Text = "laps";
                    normal = 4.5;
                    moderate = 5.8;
                    intense = 9.8;
                    break;
                 case "Dancing":
                    lblmetric2.Text = "Heart Rate:";
                    label8.Text = "BPM";
                    normal = 3.0;
                    moderate = 4.5;
                    intense = 7.8;
                    break;
                case "Rope Jump":
                    lblmetric2.Text = "Counter:";
                    label8.Text = "counts";
                    normal = 8.8;
                    moderate = 10.0;
                    intense = 12.0;
                    break;
                case "Bicycling":
                    lblmetric2.Text = "Heart Rate:";
                    label8.Text = "BPM";
                    normal = 4.0;
                    moderate = 6.8;
                    intense = 12.0;
                    break;
                case "Running":
                    lblmetric2.Text = "Heart Rate:";
                    label8.Text = "BPM";
                    normal = 6.0;
                    moderate = 9.8;
                    intense = 11.0;
                    break;
                default:// For walking
                    lblmetric2.Text = "Step Count:";
                    label8.Text = "steps";
                    normal = 2.0;
                    moderate = 4;
                    intense = 5;
                    break;
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AddActivity()) return;
                LoadData();
                double duration = Convert.ToDouble(txtTimeTaken.Text);
                total_Cal += CalculateCalburn(duration); // Add current activity's calories
                total_ActCount = total_ActCount + 1;
                total_ActDuration += duration;
                if (!AddToReport()) return;               
                ActivityID_increment();
                ReportID_increment();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the numerical value for metric data ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool AddActivity()
        {
            if (cboactivity.SelectedItem == null)
            {
                MessageBox.Show("Please select the activity type", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboIntensity.SelectedItem == null)
            {
                MessageBox.Show("Please choose intensity of the activity", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtmetric2.Text))
            {
                MessageBox.Show("Please enter a value for second metric", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmetric2.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtTimeTaken.Text))
            {
                MessageBox.Show("Please enter a value for Time Taken.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimeTaken.Focus();
                return false;
            }
            else if (txtTimeTaken.Text[0].ToString() == "0")
            {
                MessageBox.Show("Please enter a valid value ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimeTaken.Focus();
                return false;
            }
            else
            {
                DataTable dt = new DataTable();
                DataTable table = objActInfo.GetWeight(ShowUserID.Text);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Please set your goal before filling the activities.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else if (table.Rows.Count > 0)
                    {
                        double time = Convert.ToDouble(txtTimeTaken.Text);
                        double calburn = CalculateCalburn(time);
                        objAct.AddActivity(ActID,
                                            ShowUserID.Text,
                                            cboactivity.SelectedItem.ToString(),
                                            cboIntensity.SelectedItem.ToString(),
                                            txtmetric2.Text,
                                            txtTimeTaken.Text,
                                            calburn.ToString());
                        MessageBox.Show("Your have burned : " + calburn.ToString() + " cal" + " for this activity.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
            } 
            return true;
        }

        private bool AddToReport()
        {
            for (int k = 0; k < dgvactivity.Rows.Count - 1; k++)
            {
                total_Cal += Convert.ToDouble(dgvactivity.Rows[k].Cells["EachAct_CalBurn"].Value);
                total_ActDuration += Convert.ToDouble(dgvactivity.Rows[k].Cells["Metric3"].Value);
                total_ActCount++;
            }            

            Total_Cal = total_Cal.ToString("N1");
            Total_ActDuration = total_ActDuration.ToString();
            Total_ActCount = total_ActCount.ToString();

            DataTable table = objActInfo.GetWeight(ShowUserID.Text);
            string Target = table.Rows[0]["TargetCalburn"].ToString();
            target = Convert.ToDouble(Target);
            progress = (target <= total_Cal) ? 100 : (total_Cal / target) * 100;//progress percentage calculation
            Progress = progress.ToString("N1");

            objReport.Insert(ReportID,
                            ShowUserID.Text,
                            Total_Cal,
                            Total_ActCount,
                            Total_ActDuration,
                            Progress);
            return true;
        }

        private double CalculateCalburn(double time)
        {
            double calburn = 0;

            //To get intensity
            string intensity = cboIntensity.SelectedItem.ToString();

            // To get weight
            DataTable dt = new DataTable();
            DataTable table = objActInfo.GetWeight(ShowUserID.Text);
            String Weight = table.Rows[0]["CurrentWeight"].ToString();
            weight = Convert.ToDouble(Weight);

            if (intensity == "Normal")
            {
                calburn = (normal * weight * 3.5 * time / 60);
            }
            else if (intensity == "Moderate")
            {
                calburn = (moderate * weight * 3.5 * time / 60);
            }
            else if (intensity == "Intense")
            {
                calburn = (intense * weight * 3.5 * time / 60);
            }

            return Math.Round(calburn, 2);
        }

        private void LoadData()//Data load method after adding activity
        {
            dtUserAct = objAct.dgvFilter(ShowUserID.Text);
            dgvactivity.DataSource = dtUserAct;
            dgvactivity.Refresh();
        }


        private void dgvactivity_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cboIntensity.SelectedItem == null) return;
            string Eachcalburn = calburn.ToString();
            string intensity = cboIntensity.SelectedItem.ToString();
            string ActivityName = cboactivity.SelectedItem.ToString();
            DataGridViewRow row = this.dgvactivity.Rows[e.RowIndex];
            ActID = row.Cells[0].Value.ToString();
            ShowUserID.Text = row.Cells[1].Value.ToString();
            ActivityName = row.Cells[2].Value.ToString();
            intensity = row.Cells[3].Value.ToString();
            txtmetric2.Text = row.Cells[4].Value.ToString();
            txtTimeTaken.Text = row.Cells[5].Value.ToString();
            Eachcalburn = row.Cells[6].Value.ToString();
            btndgvDelete.Enabled = true;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            contextMenuStripName.Show(lblName, 1, lblName.Height);//for user's name and ID
        }

        private void btndgvShow_Click(object sender, EventArgs e)
        {
            
        }

        private void frmUserActivities_Load(object sender, EventArgs e)
        {
             lblName.Text = frmUserLogIn.UserFirstName[0].ToString();
             ShowUserID.Text = frmUserLogIn.UserID;
             ShowUserName.Text = frmUserLogIn.UserFirstName;                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ActivityID_increment();
            dgvactivity.ClearSelection();
            cboactivity.SelectedIndex = -1;
            cboIntensity.SelectedIndex = -1;
            txtTimeTaken.Text = " ";
            txtmetric2.Text = " ";
        }

        private void btndgvDelete_Click(object sender, EventArgs e)
        {
            if (dgvactivity.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row before attemption to delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string actID = dgvactivity.SelectedRows[0].Cells["ActivityID"].Value.ToString();
            objAct.DeleteActivity(actID);
            MessageBox.Show(" Your chosen activity data are deleted sucessfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // dgv filter for only user
            dtUserAct = objAct.dgvFilter(ShowUserID.Text);
            string CalBurn = dtUserAct.AsEnumerable().Sum(x => Convert.ToDouble(x["EachAct_CalBurn"])).ToString();
            // To add all the user's cal burn value from the field

            double total_Cal = Convert.ToDouble(CalBurn);//to compare with percent
            int totalActCount = dtUserAct.Rows.Count;// for row count
            string TotalActivity_Count = Convert.ToString(Convert.ToDouble(totalActCount));
            string TotalDuration = dtUserAct.AsEnumerable().Sum(x => Convert.ToDouble(x["Metric3"])).ToString();
            Total_Cal = total_Cal.ToString("N1");

            DataTable table = objActInfo.GetWeight(ShowUserID.Text);
            string Target = table.Rows[0]["TargetCalburn"].ToString();
            target = Convert.ToDouble(Target);
            progress = (target <= total_Cal) ? 100 : (total_Cal / target) * 100;
            Progress = progress.ToString("N1");
            objReport.Insert(ReportID,
                            ShowUserID.Text,
                            Total_Cal,
                            TotalActivity_Count,
                            TotalDuration,
                            Progress);

            LoadData();
            ActivityID_increment();
            ReportID_increment();
        }

        private void btnShow_Click(object sender, EventArgs e)//Show data grid view
        {
            dtUserAct = objAct.dgvFilter(ShowUserID.Text);//filter for only user's data
            dgvactivity.DataSource = dtUserAct;
            dgvactivity.Refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserHome Home = new frmUserHome();
            Home.Show();
        }

        public void ReportID_increment()//report ID
        {
            ReportID = GetNextID("R_", objReport.GetData());
        }
    }
}
