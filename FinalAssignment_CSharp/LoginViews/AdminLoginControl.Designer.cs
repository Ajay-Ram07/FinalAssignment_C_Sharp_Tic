namespace FinalAssignment_CSharp.LoginViews
{
    partial class AdminLoginControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtAdminPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAdminUserID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminLogin, 0, 5);
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID / Email :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAdminUserID
            // 
            this.txtAdminUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminUserID.Location = new System.Drawing.Point(35, 191);
            this.txtAdminUserID.Name = "txtAdminUserID";
            this.txtAdminUserID.Size = new System.Drawing.Size(606, 15);
            this.txtAdminUserID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminPassword.Location = new System.Drawing.Point(35, 367);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(606, 15);
            this.txtAdminPassword.TabIndex = 4;
            this.txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminLogin.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAdminLogin.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(279, 442);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(117, 40);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            // 
            // AdminLoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminLoginControl";
            this.Size = new System.Drawing.Size(676, 513);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}
