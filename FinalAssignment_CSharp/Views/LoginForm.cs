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

namespace FinalAssignment_CSharp.Views
{
    public partial class LoginForm : Form
    {
        private LoginController loginController;
        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController(DataBase.GetConnection());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = loginController.Authenticate(txtEmail.Text, txtPassword.Text);

            if (user != null)
            {
                //MessageBox.Show($"Welcome {user.Name} ({user.Role})!");
                this.Hide();

                switch (user.Role.ToLower())
                {
                    case "admin":
                        new AdminDashboard(user).ShowDialog(); break;

                    case "student":
                        new StudentDashboard(user).ShowDialog(); break;

                    default:
                        MessageBox.Show("No Dashboard For This Role...");
                        this.Show();
                        break;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
