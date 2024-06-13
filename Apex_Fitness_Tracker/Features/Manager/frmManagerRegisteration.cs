using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Apex_Fitness_Tracker.Features.User;


namespace Apex_Fitness_Tracker.Features.Manager
{
    
    public partial class frmManagerRegisteration : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.Manager_SignUpTableAdapter objManager = new Apex_Fitness_TrackerDataSetTableAdapters.Manager_SignUpTableAdapter();
        DataTable dtManager = new DataTable();
        string gender = " ";
        string photo_path;
        DateTime DateofBirth;

        public frmManagerRegisteration()
        {
            InitializeComponent();
            AdminID_increment();
            txtManagerpassword.UseSystemPasswordChar = true;
            // To make password char invisible unless the manager click show check box
            txtManagerconfirmpw.UseSystemPasswordChar = true;
            dtManager = objManager.GetData();
            dgvManagerList.DataSource = dtManager;
            dgvManagerList.Refresh();

            
        }
        public void SetGpboxEditVisible(bool visible)//Gp box control for dgv visibility and update, delete buttons
        {
            gpboxEdit.Visible = visible;
        }

        public void AdminID_increment()
        {
            DataTable dt = new DataTable();
            dt = objManager.GetData();

            if (dt.Rows.Count == 0)
            {
                txtManagerID.Text = "M_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;// To get the last ID from Manager_SignUp Table
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(2, 3));// To break the M_ part out to calculate increment for ID

                if (newID >= 1 && newID < 9)
                {
                    txtManagerID.Text = "M_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    txtManagerID.Text = "M_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    txtManagerID.Text = "M_" + (newID + 1);
                }
                else
                {
                    txtManagerID.Text = "Full Limit";
                }
            }
        }
        private bool IsGmailAddress(string email)//To avoid invalid email
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private bool Validation()
        {
            string Manager_password = txtManagerpassword.Text;
            if (txtManagerfname.Text == "")
            {
                MessageBox.Show(" Please fill Your First Name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerfname.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtManagerfname.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtManagerfname.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show(" Please fill Your First Name only as letter and number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerfname.Focus();
                return false;
            }

            if (txtManagerlname.Text == "")
            {
                MessageBox.Show(" Please fill Your Last Name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerlname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtManagerlname.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtManagerlname.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show(" Please fill Your Last Name only as letter and number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerlname.Focus();
                return false;
            }

            if (txtManagerphno.Text == "")
            {
                MessageBox.Show(" Please fill Your Phone Number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerphno.Focus();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtManagerphno.Text, @"^\d{11}$"))// To avoid invaild ph num
            {
                MessageBox.Show("Phone Number must be exactly 11 digits long numbers", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerphno.Focus();
                return false;
            }
            if (txtManagerEmail.Text == "")
            {
                MessageBox.Show("Please Enter your email", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerEmail.Focus();
                return false;
            }

            if (!IsGmailAddress(txtManagerEmail.Text))
            {
                MessageBox.Show("Please Enter a valid email address", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerEmail.Focus();
                return false;
            }
            
            if (txtManagerpassword.Text == "")
            {
                MessageBox.Show("Please Enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerpassword.Focus();
                return false;
            }

            if (!Manager_password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one upper character", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerpassword.Focus();
                return false;
            }

            if (!Manager_password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one lower characters", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerpassword.Focus();
                return false;
            }

            if (!Manager_password.Any(char.IsDigit))//for password to be more safety
            {
                MessageBox.Show("Password must contain at least one digit", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerpassword.Focus();
                return false;
            }

            if (txtManagerpassword.Text.Length < 12)
            {
                MessageBox.Show(" Password must be exactly 12 characters ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerpassword.Focus();
                return false;
            }

            if (txtManagerconfirmpw.Text == "")
            {
                MessageBox.Show("Plaese Enter your password to confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerconfirmpw.Focus();
                return false;
            }

            if (txtManagerpassword.Text != txtManagerconfirmpw.Text)
            {
                MessageBox.Show("Plaese Re-enter Password to Confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManagerconfirmpw.Focus();
                return false;
            }


            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            

            gender = cboManagergender.SelectedItem.ToString();
            DateofBirth = dtpBirthDate.Value;
            // For manager photo upload
            string photo_location = "C:\\SU YEE MYAT MOE_P000000_DDOOCP_GA\\Program\\Fitness_Activity_Tracking_Program\\Fitness_Activity_Tracking_Program\\bin\\Debug";
            photo_path = Path.Combine(photo_location, txtManagerfname.Text + ".jpg");
            if (Managerpicture.Image != null)// to handle with null image
            {
                Image i1 = Managerpicture.Image;
                i1.Save(photo_path);
            }
            //Encapsulation
            frmManagerRegister_dto dto = new frmManagerRegister_dto();
            dto.ManagerID = txtManagerID.Text.Trim();
            dto.ManagerFirstName = txtManagerfname.Text.Trim();
            dto.ManagerLastName = txtManagerlname.Text.Trim();
            dto.ManagerDateofBirth = DateofBirth.ToString();
            dto.ManagerGender = gender;
            dto.ManagerPhNum = txtManagerphno.Text.Trim();      
            dto.ManagerEmail = txtManagerEmail.Text.Trim();
            dto.ManagerPassword = txtManagerpassword.Text.Trim();
            dto.ManagerConfirmPassword = txtManagerconfirmpw.Text.Trim();
            dto.ManagerPhoto = photo_path;

            Save(dto);
            ClearForm();//To advoid duplicate data saving
            dtManager = objManager.GetData();
            dgvManagerList.DataSource = dtManager;
            dgvManagerList.Refresh();
            AdminID_increment();


        }

        private void Save(frmManagerRegister_dto dto)
        {
            objManager.Insert(
               dto.ManagerID,
               dto.ManagerFirstName,
               dto.ManagerLastName,
               dto.ManagerDateofBirth,
               dto.ManagerGender,
               dto.ManagerPhNum,
               dto.ManagerEmail,
               dto.ManagerPassword,
               dto.ManagerConfirmPassword,
               dto.ManagerPhoto);

            MessageBox.Show(" Your data are sucessfully saved", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Managerpicture_Click_1(object sender, EventArgs e)//For profile photo uploading
        {
            OpenFileDialog openbox = new OpenFileDialog();
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                openbox.Filter = "(*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";//Filter the photo type to avoid large photo size
                if (openbox.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(openbox.FileName);
                }
            }
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)//PW charvisibility control
        {
            if (chkShowPW.Checked == true)
            {
                txtManagerpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtManagerpassword.UseSystemPasswordChar = true;
            }

        }

        private void chkShowConfirmPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowConfirmPW.Checked == true)
            {
                txtManagerconfirmpw.UseSystemPasswordChar = false;
            }
            else
            {
                txtManagerconfirmpw.UseSystemPasswordChar = true;
            }
        }

        private void dgvManagerList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgvManagerList.Rows.Count)// to avoid argument was out of range exception
            {
                DataGridViewRow row = this.dgvManagerList.Rows[e.RowIndex];
                int numColumns = row.Cells.Count;
                string[] cellValues = new string[numColumns];
                for (int i = 0; i < numColumns; i++)
                {
                    cellValues[i] = row.Cells[i].Value.ToString();
                }
                txtManagerID.Text = cellValues[0];
                txtManagerfname.Text = cellValues[1];
                txtManagerlname.Text = cellValues[2];
                txtManagerphno.Text = cellValues[5];
                txtManagerEmail.Text = cellValues[6];
                txtManagerpassword.Text = cellValues[7];
                if (numColumns > 8)// to  prevents an index out of range exception from being thrown.
                {
                    txtManagerconfirmpw.Text = cellValues[8];
                }
            }
            else
            {
                MessageBox.Show("Invalid row index","Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            gender = cboManagergender.SelectedItem.ToString();
            DateofBirth = dtpBirthDate.Value;

            objManager.UpdateManagerList(
                txtManagerfname.Text,
                txtManagerlname.Text, 
                txtManagerphno.Text,
                txtManagerEmail.Text,
                txtManagerpassword.Text, 
                txtManagerconfirmpw.Text, 
                txtManagerID.Text);

            dtManager = objManager.GetData();
            dgvManagerList.DataSource = dtManager;
            dgvManagerList.Refresh();
            MessageBox.Show(" Your data are updated sucessfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objManager.DeleteManager(txtManagerID.Text);
            dtManager = objManager.GetData();
            dgvManagerList.DataSource = dtManager;
            dgvManagerList.Refresh();
            MessageBox.Show(" Your data are deleted sucessfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDelete.Enabled = false;

        }

        private void btnSearchfname_Click(object sender, EventArgs e)
        {
            dtManager = objManager.GetData();
            dgvManagerList.DataSource = dtManager;
            DataView dv = dtManager.DefaultView;
            dv.RowFilter = "ManagerFname LIKE '" + txtManagersearch.Text + "%'";// finding with first name
            dgvManagerList.DataSource = dv;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please LogIn to continue", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            frmManagerLogIn LogIn = new frmManagerLogIn();
            LogIn.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtManagerID.Clear();
            txtManagerfname.Clear();
            txtManagerlname.Clear();
            txtManagerphno.Clear();
            txtManagerEmail.Clear();
            txtManagerpassword.Clear();
            txtManagerconfirmpw.Clear();
            cboManagergender.SelectedItem = "Male";
            dtpBirthDate.Value = DateTime.Now;
            Managerpicture.Image = null;
            AdminID_increment();
            btnSave.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dtManager = objManager.GetData();
            dgvManagerList.DataSource = dtManager;
            dgvManagerList.Refresh();
        }

        private void frmManagerRegisteration_Load(object sender, EventArgs e)
        {
            
        }



    }
}
