namespace Apex_Fitness_Tracker.Features.Manager
{
    partial class frmManagerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManagerReport = new System.Windows.Forms.DataGridView();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.contextMenuStripName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowName = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowID = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerReport)).BeginInit();
            this.contextMenuStripName.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnnext);
            this.groupBox1.Controls.Add(this.btnshowall);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvManagerReport);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Location = new System.Drawing.Point(68, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(293, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manager Report";
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.Control;
            this.btnnext.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.Indigo;
            this.btnnext.Location = new System.Drawing.Point(430, 443);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(107, 37);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "Exit";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click_1);
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnshowall.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.ForeColor = System.Drawing.Color.White;
            this.btnshowall.Location = new System.Drawing.Point(281, 439);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(107, 44);
            this.btnshowall.TabIndex = 4;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsearch.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(495, 85);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(105, 37);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(194, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter UserID:";
            // 
            // dgvManagerReport
            // 
            this.dgvManagerReport.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvManagerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerReport.Location = new System.Drawing.Point(65, 143);
            this.dgvManagerReport.Name = "dgvManagerReport";
            this.dgvManagerReport.RowTemplate.Height = 24;
            this.dgvManagerReport.Size = new System.Drawing.Size(653, 276);
            this.dgvManagerReport.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(337, 95);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(129, 23);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Lavender;
            this.btnName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnName.ForeColor = System.Drawing.Color.Indigo;
            this.btnName.Location = new System.Drawing.Point(822, 22);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(47, 30);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "S";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // contextMenuStripName
            // 
            this.contextMenuStripName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowName,
            this.ShowID});
            this.contextMenuStripName.Name = "contextMenuStripName";
            this.contextMenuStripName.Size = new System.Drawing.Size(70, 48);
            // 
            // ShowName
            // 
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(69, 22);
            // 
            // ShowID
            // 
            this.ShowID.Name = "ShowID";
            this.ShowID.Size = new System.Drawing.Size(69, 22);
            // 
            // frmManagerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(42)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(910, 646);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Report";
            this.Load += new System.EventHandler(this.frmManagerReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerReport)).EndInit();
            this.contextMenuStripName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManagerReport;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripName;
        private System.Windows.Forms.ToolStripMenuItem ShowName;
        private System.Windows.Forms.ToolStripMenuItem ShowID;
    }
}