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
    public partial class LecturerLoginControl : UserControl
    {
        private LoginController LoginController;
        public LecturerLoginControl()
        {
            InitializeComponent();
            LoginController = new LoginController(DataBase.GetConnection());

        }

        private void btnLecturerLogin_Click(object sender, EventArgs e)
        {
            string email = txtLecturerUserID.Text.Trim();
            string password = txtLecturerPassword.Text.Trim();

            var user = LoginController.Authenticate(email, password, "lecturer");

            if (user != null)
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Invalid staff credentials");
            }
        }
    }
}
