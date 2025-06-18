using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalAssignment_CSharp.Models;

namespace FinalAssignment_CSharp.Views
{
    public partial class AdminDashboard : Form
    {
        private User loggedInUser;
        public AdminDashboard(User user)
        {
            InitializeComponent();
            loggedInUser = user;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {loggedInUser.Name}! You're Logged in as {loggedInUser.Role}.";
            lblDateTime.Text = $"Date : {DateTime.Now.ToShortDateString()} | Time : {DateTime.Now.ToShortTimeString()}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
