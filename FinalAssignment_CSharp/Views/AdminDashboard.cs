using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalAssignment_CSharp.ControlViews;
using FinalAssignment_CSharp.Data;
using FinalAssignment_CSharp.Models;

namespace FinalAssignment_CSharp.Views
{
    public partial class AdminDashboard : Form
    {
        private User _loggedInUser;
        public AdminDashboard(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            RegisterUserControl uc = new RegisterUserControl(DataBase.GetConnection());
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ManageMarksUserControl marksUC = new ManageMarksUserControl(DataBase.GetConnection());
            marksUC.Dock = DockStyle.Fill;
            panelMain.Controls.Add(marksUC);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ManageCoursesUserControl courseUC = new ManageCoursesUserControl(DataBase.GetConnection());
            courseUC.Dock = DockStyle.Fill;
            panelMain.Controls.Add(courseUC);
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            TimetableUserControl timetableUC = new TimetableUserControl(DataBase.GetConnection());
            timetableUC.Dock = DockStyle.Fill;
            panelMain.Controls.Add(timetableUC);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Close current dashboard
                this.Hide();
                Application.Exit();

                // Open login form again
                //LoginFormFinal loginForm = new LoginFormFinal();
                //loginForm.Show();
            }
        }

    }
}
