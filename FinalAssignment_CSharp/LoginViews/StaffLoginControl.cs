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

namespace FinalAssignment_CSharp.LoginViews
{
    public partial class StaffLoginControl : UserControl
    {
        private LoginController loginController;

        public StaffLoginControl()
        {

            InitializeComponent();
            loginController = new LoginController(DataBase.GetConnection());
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {
            string email = txtStaffUserID.Text.Trim();
            string password = txtStaffPassword.Text.Trim();

            var user = loginController.Authenticate(email, password, "staff");

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                // new StaffDashboard(user).Show(); // if dashboard is ready
            }
            else
            {
                MessageBox.Show("Invalid staff credentials!");
            }
        }

    }
}
