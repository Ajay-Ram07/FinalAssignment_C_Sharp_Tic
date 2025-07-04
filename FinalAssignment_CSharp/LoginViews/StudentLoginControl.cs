﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalAssignment_CSharp.Controllers;
using FinalAssignment_CSharp.Data;

namespace FinalAssignment_CSharp.LoginViews
{
    public partial class StudentLoginControl : UserControl
    {

        private LoginController loginController;
        public StudentLoginControl()
        {
            InitializeComponent();
            loginController = new LoginController(DataBase.GetConnection());
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string email = txtStudentUserID.Text.Trim();
            string password = txtStudentPassword.Text.Trim();

            var user = loginController.Authenticate(email, password, "student");

            if (user != null)
            {
                MessageBox.Show("Login Success!");
                // new StaffDashboard(user).Show();
            }
            else
            {
                MessageBox.Show("Invalid Staff credentials.");
            }
        }
    }
}
