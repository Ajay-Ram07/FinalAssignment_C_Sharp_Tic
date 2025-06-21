namespace FinalAssignment_CSharp.LoginViews
{
    partial class StaffLoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtStaffUserID = new System.Windows.Forms.TextBox();
            this.btnStaffLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtStaffPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStaffUserID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStaffLogin, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.75926F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.24074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaffPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffPassword.Location = new System.Drawing.Point(35, 367);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(606, 15);
            this.txtStaffPassword.TabIndex = 4;
            this.txtStaffPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(203, 260);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(270, 51);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(668, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Staff Login";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(203, 78);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(270, 51);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User ID / Email :";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStaffUserID
            // 
            this.txtStaffUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaffUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffUserID.Location = new System.Drawing.Point(35, 195);
            this.txtStaffUserID.Name = "txtStaffUserID";
            this.txtStaffUserID.Size = new System.Drawing.Size(606, 15);
            this.txtStaffUserID.TabIndex = 2;
            // 
            // btnStaffLogin
            // 
            this.btnStaffLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStaffLogin.BackColor = System.Drawing.Color.Plum;
            this.btnStaffLogin.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnStaffLogin.Location = new System.Drawing.Point(279, 442);
            this.btnStaffLogin.Name = "btnStaffLogin";
            this.btnStaffLogin.Size = new System.Drawing.Size(117, 40);
            this.btnStaffLogin.TabIndex = 5;
            this.btnStaffLogin.Text = "Login";
            this.btnStaffLogin.UseVisualStyleBackColor = false;
            this.btnStaffLogin.Click += new System.EventHandler(this.btnStaffLogin_Click);
            // 
            // StaffLoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StaffLoginControl";
            this.Size = new System.Drawing.Size(676, 513);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtStaffUserID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Button btnStaffLogin;



        #endregion
    }
}
