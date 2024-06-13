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


namespace Apex_Fitness_Tracker.Features.User
{
    public partial class frmUserRegister : Form
    {
        Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter objUser = new Apex_Fitness_TrackerDataSetTableAdapters.User_SignUpTableAdapter();
        DataTable dtUser = new DataTable();

        Apex_Fitness_TrackerDataSetTableAdapters.User_GoalTableAdapter objUserGoal = new Apex_Fitness_TrackerDataSetTableAdapters.User_GoalTableAdapter();

        string gender = " ";
        string photo_path;
        DateTime DateofBirth;

        public frmUserRegister()
        {
            InitializeComponent();
            UserID_increment();
            txtUserpassword.UseSystemPasswordChar = true;// To make password char invisible unless the person click show check box
            txtUserconfirmpw.UseSystemPasswordChar = true;
            dtUser = objUser.GetData();
            dgvUserList.DataSource = dtUser;
            dgvUserList.Refresh();

        }
        public void SetGpboxEditVisible(bool visible)// Gpbox control for dgv visibility and update, delete buttons
        {
            gpboxEdit.Visible = visible;
        }

        public void UserID_increment()
        {
            DataTable dt = new DataTable();
            dt = objUser.GetData();

            if (dt.Rows.Count == 0)
            {
                txtUserID.Text = "U_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;// To get the last ID from User_SignUp Table
                string oldID = dt.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(2, 3));// To break the U_ part out to calculate increment for ID

                if (newID >= 1 && newID < 9)
                {
                    txtUserID.Text = "U_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    txtUserID.Text = "U_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    txtUserID.Text = "U_" + (newID + 1);
                }
                else
                {
                    txtUserID.Text = "Full Limit";
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
            string User_password = txtUserpassword.Text;
            if (txtUserfname.Text == "")
            {
                MessageBox.Show(" Please fill Your First Name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserfname.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUserfname.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtUserfname.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show(" Please fill Your First Name only as letter and number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserfname.Focus();
                return false;
            }

            if (txtUserlname.Text == "")
            {
                MessageBox.Show(" Please fill Your Last Name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserlname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUserlname.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtUserlname.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show(" Please fill Your Last Name only as letter and number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserlname.Focus();
                return false;
            }

            if (txtUserphno.Text == "")
            {
                MessageBox.Show(" Please fill Your Phone Number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserphno.Focus();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUserphno.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Phone Number must be exactly 11 digits long numbers", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserphno.Focus();
                return false;
            }
            if (txtUserEmail.Text == "")
            {
                MessageBox.Show("Please Enter your email", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserEmail.Focus();
                return false;
            }

            if (!IsGmailAddress(txtUserEmail.Text))
            {
                MessageBox.Show("Please Enter a valid email address", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserEmail.Focus();
                return false;
            }

            if (txtUserpassword.Text == "")
            {
                MessageBox.Show("Please Enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserpassword.Focus();
                return false;
            }

            if (!User_password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least One upper one character", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserpassword.Focus();
                return false;
            }

            if (!User_password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least One lower characters", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserpassword.Focus();
                return false;
            }

            if (!User_password.Any(char.IsDigit))//for password to be more secure
            {
                MessageBox.Show("Password must contain at least One digit", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserpassword.Focus();
                return false;
            }

            if (txtUserpassword.Text.Length < 12)
            {
                MessageBox.Show(" Password must be exactly 12 characters ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserpassword.Focus();
                return false;
            }

            if (txtUserconfirmpw.Text == "")
            {
                MessageBox.Show("Plaese Enter your password to confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserconfirmpw.Focus();
                return false;
            }

            if (txtUserpassword.Text != txtUserconfirmpw.Text)
            {
                MessageBox.Show("Plaese Re-enter Password to Confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserconfirmpw.Focus();
                return false;
            }


            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;


            gender = cboUsergender.SelectedItem.ToString();
            DateofBirth = dtpBirthDate.Value;
            //To add Photo 
            string photo_location = "C:\\SU YEE MYAT MOE_P000000_DDOOCP_GA\\Program\\Fitness_Activity_Tracking_Program\\Fitness_Activity_Tracking_Program\\bin\\Debug";
            photo_path = Path.Combine(photo_location, txtUserfname.Text + ".jpg");
            if (Userpicture.Image != null)// to handle with null image
            {
                Image i1 = Userpicture.Image;
                i1.Save(photo_path);
            }
            //Encapsulation from User_Dto
            frmUserRegister_dto dto = new frmUserRegister_dto();
            dto.UserID = txtUserID.Text.Trim();
            dto.UserFirstName = txtUserfname.Text.Trim();
            dto.UserLastName = txtUserlname.Text.Trim();
            dto.UserDateofBirth = DateofBirth.ToString();
            dto.UserGender = gender;
            dto.UserPhNum = txtUserphno.Text.Trim();
            dto.UserEmail = txtUserEmail.Text.Trim();
            dto.UserPassword = txtUserpassword.Text.Trim();
            dto.UserConfirmPassword = txtUserconfirmpw.Text.Trim();
            dto.UserPhoto = photo_path;
            Save(dto);
            ClearForm();// To avoid duplicate data saving
            dtUser = objUser.GetData();
            dgvUserList.DataSource = dtUser;
            dgvUserList.Refresh();
            UserID_increment();
        }
        private void Save(frmUserRegister_dto dto)
        {
            objUser.Insert(
               dto.UserID,
               dto.UserFirstName,
               dto.UserLastName,
               dto.UserDateofBirth,
               dto.UserGender,
               dto.UserPhNum,
               dto.UserEmail,
               dto.UserPassword,
               dto.UserConfirmPassword,
               dto.UserPhoto);

            MessageBox.Show(" Your data are sucessfully saved", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Userpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openbox = new OpenFileDialog();
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                openbox.Filter = "(*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";//photo type limit to control big file size
                if (openbox.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(openbox.FileName);
                }
            }
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)//To see PW char
        {
            if (chkShowPW.Checked == true)
            {
                txtUserpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserpassword.UseSystemPasswordChar = true;
            }
        }

        private void chkShowConfirmPW_CheckedChanged(object sender, EventArgs e)//To see confirmPW char
        {
            if (chkShowConfirmPW.Checked == true)
            {
                txtUserconfirmpw.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserconfirmpw.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtUserID.Clear();
            txtUserfname.Clear();
            txtUserlname.Clear();
            txtUserphno.Clear();
            txtUserEmail.Clear();
            txtUserpassword.Clear();
            txtUserconfirmpw.Clear();
            cboUsergender.SelectedItem = "Male";
            dtpBirthDate.Value = DateTime.Now;
            Userpicture.Image = null;
            UserID_increment();
            btnSave.Enabled = true;
        }
        

        private void dgvUserList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < this.dgvUserList.Rows.Count)// to avoid argument was out of range exception
            {
                DataGridViewRow row = this.dgvUserList.Rows[e.RowIndex];
                int numColumns = row.Cells.Count;
                string[] cellValues = new string[numColumns];
                for (int i = 0; i < numColumns; i++)
                {
                    cellValues[i] = row.Cells[i].Value.ToString();
                }
                txtUserID.Text = cellValues[0];
                txtUserfname.Text = cellValues[1];
                txtUserlname.Text = cellValues[2];
                txtUserphno.Text = cellValues[5];
                txtUserEmail.Text = cellValues[6];
                txtUserpassword.Text = cellValues[7];
                if (numColumns > 8)// to  prevents an index out of range exception from being thrown.
                {
                    txtUserconfirmpw.Text = cellValues[8];
                }
            }
            else
            {
                MessageBox.Show("Invalid row index", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;//To stop saving during updating to avoid duplicat ID
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            gender = cboUsergender.SelectedItem.ToString();
            DateofBirth = dtpBirthDate.Value;

            objUser.UpdateUserList(
                txtUserfname.Text,
                txtUserlname.Text,
                txtUserphno.Text,
                txtUserEmail.Text,
                txtUserpassword.Text,
                txtUserconfirmpw.Text,
                txtUserID.Text);
            dtUser = objUser.GetData();
            dgvUserList.DataSource = dtUser;
            dgvUserList.Refresh();
            MessageBox.Show(" Your data are updated sucessfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataTable dtcount = new DataTable();
            dtcount = objUserGoal.GetDataByUserID(txtUserID.Text);
            if (dtcount.Rows.Count > 0)
            {
                // If the user already set goal, its primary key is connected as other class foreign key so the account cannot be deleted unless its goal and activity and report is deleted
                MessageBox.Show(" Please delete other related data of this account to delete the whole account", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                objUser.DeleteUser(txtUserID.Text);
                dtUser = objUser.GetData();
                dgvUserList.DataSource = dtUser;
                dgvUserList.Refresh();
                MessageBox.Show(" Your data are deleted sucessfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDelete.Enabled = false;
            }
        }

        private void btnSearchfname_Click(object sender, EventArgs e)//Search user
        {
            dtUser = objUser.GetData();
            dgvUserList.DataSource = dtUser;
            DataView dv = dtUser.DefaultView;
            dv.RowFilter = "UserFname LIKE '" + txtUsersearch.Text + "%'";
            dgvUserList.DataSource = dv;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtUser = objUser.GetData();
            dgvUserList.DataSource = dtUser;
            dgvUserList.Refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please LogIn to continue", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            frmFirstIntro LogIn = new frmFirstIntro();
            // If the manager enter this form form its home page, this way is used to LogIn again to get Manager's own Home again
            LogIn.Show();
        }

        private void frmUserRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
