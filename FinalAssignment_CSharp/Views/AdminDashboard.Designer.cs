namespace FinalAssignment_CSharp.Views
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpModules = new System.Windows.Forms.GroupBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWelcome.Font = new System.Drawing.Font("Perpetua Titling MT", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(293, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(186, 53);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Cyan;
            this.lblDateTime.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(335, 62);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(86, 31);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(341, 401);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "button1";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // grpModules
            // 
            this.grpModules.BackColor = System.Drawing.Color.Transparent;
            this.grpModules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpModules.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpModules.Location = new System.Drawing.Point(206, 110);
            this.grpModules.Name = "grpModules";
            this.grpModules.Size = new System.Drawing.Size(358, 243);
            this.grpModules.TabIndex = 3;
            this.grpModules.TabStop = false;
            this.grpModules.Text = "Admin Modules";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(12, 9);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(75, 75);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.grpModules);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblWelcome);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpModules;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}