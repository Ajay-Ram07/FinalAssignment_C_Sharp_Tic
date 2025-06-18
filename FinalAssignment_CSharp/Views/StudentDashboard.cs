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
    public partial class StudentDashboard : Form
    {
        private User loggedInUser;
        public StudentDashboard(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {loggedInUser.Name}! You are logged in as {loggedInUser.Role}.";
            lblDateTime.Text = $"Date: {DateTime.Now.ToShortDateString()} | Time: {DateTime.Now.ToShortTimeString()}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
