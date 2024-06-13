namespace Apex_Fitness_Tracker.Features.User
{
    partial class frmFirstIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirstIntro));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lnkManagerEnter = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO APEX FITNESS TRACKER";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEnter.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(616, 549);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(166, 49);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Get Started";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lnkManagerEnter
            // 
            this.lnkManagerEnter.AutoSize = true;
            this.lnkManagerEnter.BackColor = System.Drawing.Color.Transparent;
            this.lnkManagerEnter.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkManagerEnter.LinkColor = System.Drawing.Color.White;
            this.lnkManagerEnter.Location = new System.Drawing.Point(630, 612);
            this.lnkManagerEnter.Name = "lnkManagerEnter";
            this.lnkManagerEnter.Size = new System.Drawing.Size(143, 21);
            this.lnkManagerEnter.TabIndex = 2;
            this.lnkManagerEnter.TabStop = true;
            this.lnkManagerEnter.Text = "Manager Access";
            this.lnkManagerEnter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkManagerEnter_LinkClicked);
            // 
            // frmFirstIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 666);
            this.Controls.Add(this.lnkManagerEnter);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFirstIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel lnkManagerEnter;
    }
}