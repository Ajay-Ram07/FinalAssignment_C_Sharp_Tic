using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment_CSharp.ControlViews
{
    public partial class ManageCoursesUserControl : UserControl
    {
        private SQLiteConnection connection;
        public ManageCoursesUserControl(SQLiteConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridStudents.Rows[e.RowIndex];
                txtStudentId.Text = row.Cells["id"].Value.ToString();
                txtStudentName.Text = row.Cells["name"].Value.ToString();
                cmbCourse.SelectedItem = row.Cells["course"].Value?.ToString(); // might be empty
            }
        }
    }
}
