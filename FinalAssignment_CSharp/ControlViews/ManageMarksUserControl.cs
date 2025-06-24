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
    public partial class ManageMarksUserControl : UserControl
    {
        private SQLiteConnection connection;
        public ManageMarksUserControl(SQLiteConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void ManageMarksUserControl_Load(object sender, EventArgs e)
        {
            LoadSubject();
        }

        private void LoadSubject()
        {
            cmbSubject.Items.Clear();
            cmbSubject.Items.AddRange(new object[]
            {
                "Mathematics",
                "Computer Networks",
                "Data Structures",
                "Database Systems",
                "Web Development"
            });
        }


    }
}
