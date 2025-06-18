using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalAssignment_CSharp.LoginViews;

namespace FinalAssignment_CSharp.Views
{
    public partial class LoginFormFinal : Form
    {
        public LoginFormFinal()
        {
            InitializeComponent();
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

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStudent.Checked)
            {
                panelCenter.Controls.Clear();

                StudentLoginControl studentLogin = new StudentLoginControl();
                studentLogin.Dock = DockStyle.Fill;

                panelCenter.Controls.Add(studentLogin);

            }
        }
    }
}
