namespace Apex_Fitness_Tracker.Features.User
{
    partial class frmUserActivities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserActivities));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboactivity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimeTaken = new System.Windows.Forms.TextBox();
            this.txtmetric2 = new System.Windows.Forms.TextBox();
            this.cboIntensity = new System.Windows.Forms.ComboBox();
            this.lblmetric3 = new System.Windows.Forms.Label();
            this.lblmetric1 = new System.Windows.Forms.Label();
            this.lblmetric2 = new System.Windows.Forms.Label();
            this.dgvactivity = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btndgvDelete = new System.Windows.Forms.Button();
            this.contextMenuStripName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUserID = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvactivity)).BeginInit();
            this.contextMenuStripName.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Lavender;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Indigo;
            this.lblName.Location = new System.Drawing.Point(827, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "S";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboactivity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(33, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cboactivity
            // 
            this.cboactivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboactivity.FormattingEnabled = true;
            this.cboactivity.Items.AddRange(new object[] {
            "Walking",
            "Running",
            "Swimming",
            "Dancing",
            "Rope Jump",
            "Bicycling"});
            this.cboactivity.Location = new System.Drawing.Point(136, 247);
            this.cboactivity.Name = "cboactivity";
            this.cboactivity.Size = new System.Drawing.Size(127, 26);
            this.cboactivity.TabIndex = 2;
            this.cboactivity.SelectedIndexChanged += new System.EventHandler(this.cboactivity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(111, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Choose your activity:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(89, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTimeTaken);
            this.groupBox2.Controls.Add(this.txtmetric2);
            this.groupBox2.Controls.Add(this.cboIntensity);
            this.groupBox2.Controls.Add(this.lblmetric3);
            this.groupBox2.Controls.Add(this.lblmetric1);
            this.groupBox2.Controls.Add(this.lblmetric2);
            this.groupBox2.Location = new System.Drawing.Point(443, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 310);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Indigo;
            this.btnClear.Location = new System.Drawing.Point(174, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNext.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(302, 243);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 34);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(55, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(305, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(299, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "steps";
            // 
            // txtTimeTaken
            // 
            this.txtTimeTaken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeTaken.Location = new System.Drawing.Point(211, 177);
            this.txtTimeTaken.Multiline = true;
            this.txtTimeTaken.Name = "txtTimeTaken";
            this.txtTimeTaken.Size = new System.Drawing.Size(82, 28);
            this.txtTimeTaken.TabIndex = 5;
            this.txtTimeTaken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmetric2
            // 
            this.txtmetric2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmetric2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetric2.Location = new System.Drawing.Point(211, 111);
            this.txtmetric2.Multiline = true;
            this.txtmetric2.Name = "txtmetric2";
            this.txtmetric2.Size = new System.Drawing.Size(82, 27);
            this.txtmetric2.TabIndex = 4;
            this.txtmetric2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboIntensity
            // 
            this.cboIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboIntensity.FormattingEnabled = true;
            this.cboIntensity.Items.AddRange(new object[] {
            "Normal",
            "Moderate",
            "Intense"});
            this.cboIntensity.Location = new System.Drawing.Point(211, 52);
            this.cboIntensity.Name = "cboIntensity";
            this.cboIntensity.Size = new System.Drawing.Size(111, 26);
            this.cboIntensity.TabIndex = 3;
            // 
            // lblmetric3
            // 
            this.lblmetric3.AutoSize = true;
            this.lblmetric3.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.lblmetric3.ForeColor = System.Drawing.Color.Indigo;
            this.lblmetric3.Location = new System.Drawing.Point(75, 180);
            this.lblmetric3.Name = "lblmetric3";
            this.lblmetric3.Size = new System.Drawing.Size(111, 21);
            this.lblmetric3.TabIndex = 2;
            this.lblmetric3.Text = "Time Taken:";
            // 
            // lblmetric1
            // 
            this.lblmetric1.AutoSize = true;
            this.lblmetric1.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.lblmetric1.ForeColor = System.Drawing.Color.Indigo;
            this.lblmetric1.Location = new System.Drawing.Point(80, 59);
            this.lblmetric1.Name = "lblmetric1";
            this.lblmetric1.Size = new System.Drawing.Size(87, 21);
            this.lblmetric1.TabIndex = 1;
            this.lblmetric1.Text = "Intensity:";
            // 
            // lblmetric2
            // 
            this.lblmetric2.AutoSize = true;
            this.lblmetric2.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.lblmetric2.ForeColor = System.Drawing.Color.Indigo;
            this.lblmetric2.Location = new System.Drawing.Point(77, 117);
            this.lblmetric2.Name = "lblmetric2";
            this.lblmetric2.Size = new System.Drawing.Size(105, 21);
            this.lblmetric2.TabIndex = 0;
            this.lblmetric2.Text = "Step Count:";
            // 
            // dgvactivity
            // 
            this.dgvactivity.AllowUserToAddRows = false;
            this.dgvactivity.AllowUserToDeleteRows = false;
            this.dgvactivity.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvactivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvactivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvactivity.Location = new System.Drawing.Point(39, 447);
            this.dgvactivity.Name = "dgvactivity";
            this.dgvactivity.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvactivity.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvactivity.RowTemplate.Height = 24;
            this.dgvactivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvactivity.Size = new System.Drawing.Size(685, 138);
            this.dgvactivity.TabIndex = 4;
            this.dgvactivity.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvactivity_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Activities List";
            // 
            // btndgvDelete
            // 
            this.btndgvDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.btndgvDelete.Font = new System.Drawing.Font("Britannic Bold", 10.8F);
            this.btndgvDelete.ForeColor = System.Drawing.Color.White;
            this.btndgvDelete.Location = new System.Drawing.Point(744, 534);
            this.btndgvDelete.Name = "btndgvDelete";
            this.btndgvDelete.Size = new System.Drawing.Size(121, 39);
            this.btndgvDelete.TabIndex = 7;
            this.btndgvDelete.Text = "Delete";
            this.btndgvDelete.UseVisualStyleBackColor = false;
            this.btndgvDelete.Click += new System.EventHandler(this.btndgvDelete_Click);
            // 
            // contextMenuStripName
            // 
            this.contextMenuStripName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowUserName,
            this.ShowUserID});
            this.contextMenuStripName.Name = "contextMenuStripName";
            this.contextMenuStripName.Size = new System.Drawing.Size(70, 48);
            // 
            // ShowUserName
            // 
            this.ShowUserName.Name = "ShowUserName";
            this.ShowUserName.Size = new System.Drawing.Size(69, 22);
            // 
            // ShowUserID
            // 
            this.ShowUserID.Name = "ShowUserID";
            this.ShowUserID.Size = new System.Drawing.Size(69, 22);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SlateBlue;
            this.btnShow.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(743, 457);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(121, 39);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmUserActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(42)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(910, 626);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btndgvDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvactivity);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserActivities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Activities";
            this.Load += new System.EventHandler(this.frmUserActivities_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvactivity)).EndInit();
            this.contextMenuStripName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvactivity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndgvDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboactivity;
        private System.Windows.Forms.Label lblmetric1;
        private System.Windows.Forms.Label lblmetric2;
        private System.Windows.Forms.Label lblmetric3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimeTaken;
        private System.Windows.Forms.TextBox txtmetric2;
        private System.Windows.Forms.ComboBox cboIntensity;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripName;
        private System.Windows.Forms.ToolStripMenuItem ShowUserName;
        private System.Windows.Forms.ToolStripMenuItem ShowUserID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
    }
}