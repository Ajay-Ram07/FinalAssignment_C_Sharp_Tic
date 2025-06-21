using System;
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
using FinalAssignment_CSharp.Views;

namespace FinalAssignment_CSharp.LoginViews
{
    public partial class AdminLoginControl : UserControl
    {
        private LoginController LoginController;
        public AdminLoginControl()
        {
            InitializeComponent();
            LoginController = new LoginController(DataBase.GetConnection());
        }
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string email = txtAdminUserID.Text.Trim();
            string password = txtAdminPassword.Text.Trim();

            var user = LoginController.Authenticate(email, password, "admin");

            if (user != null)
            {
                MessageBox.Show("Login Success!");
                // new StaffDashboard(user).Show();

                if (user.Role == "admin")
                {
                    AdminDashboard dashboard = new AdminDashboard(user); // Or pass 'user' if needed
                    dashboard.Show();
                    this.Hide(); // Important!
                }
            }
            else
            {
                MessageBox.Show("Invalid Staff credentials.");
            }

        }
    }
}
