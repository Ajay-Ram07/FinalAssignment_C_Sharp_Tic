using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalAssignment_CSharp.Data;
using FinalAssignment_CSharp.LoginViews;

namespace FinalAssignment_CSharp.Views
{
    public partial class LoginFormFinal : Form
    {
        public LoginFormFinal()
        {
            InitializeComponent();
            DataBaseInitializer.InitializeDatabase();
        }

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAdmin.Checked)
            {
                // Clear old controls
                panelCenter.Controls.Clear();

                // Create instance of AdminLoginControl
                AdminLoginControl adminLogin = new AdminLoginControl();
                adminLogin.Dock = DockStyle.Fill;

                // Add to center panel
                panelCenter.Controls.Add(adminLogin);
            }
        }



        /*private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStudent.Checked)
            {
                panelCenter.Controls.Clear();

                StudentLoginControl studentLogin = new StudentLoginControl();
                studentLogin.Dock = DockStyle.Fill;

                panelCenter.Controls.Add(studentLogin);

            }
        }

        private void rdoLecturer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLecturer.Checked)
            {
                panelCenter.Controls.Clear();

                LecturerLoginControl lecturerLogin = new LecturerLoginControl();
                lecturerLogin.Dock = DockStyle.Fill;

                panelCenter.Controls.Add(lecturerLogin);
            }
        }

        private void rdoStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStaff.Checked)
            {
                panelCenter.Controls.Clear();

                StaffLoginControl staffLogin = new StaffLoginControl();
                staffLogin.Dock = DockStyle.Fill;

                panelCenter.Controls.Add(staffLogin);
            }
        }*/

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStudent.Checked)
            {
                MessageBox.Show("Student login is under maintenance.\nPlease try again later.",
                                "Maintenance Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                rdoAdmin.Checked = true; // fallback to Admin
            }
        }

        private void rdoLecturer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLecturer.Checked)
            {
                MessageBox.Show("Lecturer login is under maintenance.\nPlease try again later.",
                                "Maintenance Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                rdoAdmin.Checked = true;
            }
        }

        private void rdoStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStaff.Checked)
            {
                MessageBox.Show("Staff login is under maintenance.\nPlease try again later.",
                                "Maintenance Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                rdoAdmin.Checked = true;
            }
        }

    }
}
