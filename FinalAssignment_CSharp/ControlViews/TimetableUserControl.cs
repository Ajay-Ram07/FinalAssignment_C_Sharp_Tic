using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FinalAssignment_CSharp.ControlViews
{
    public partial class TimetableUserControl : UserControl
    {
        private SQLiteConnection connection;
        private int selectedTimetableId = -1;

        public TimetableUserControl(SQLiteConnection conn)
        {
            InitializeComponent();
            connection = conn;
            LoadTimetable();
        }

        private void LoadTimetable()
        {
            string query = "SELECT * FROM timetable ORDER BY day, time";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                adapter.Fill(dt);
                dataGridTimetable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading timetable: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbDay.Text) ||
                string.IsNullOrWhiteSpace(txtTime.Text) ||
                string.IsNullOrWhiteSpace(txtSubject.Text) ||
                string.IsNullOrWhiteSpace(txtLecturer.Text) ||
                string.IsNullOrWhiteSpace(txtRoom.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = "INSERT INTO timetable (day, time, subject, lecturer, room) VALUES (@day, @time, @subject, @lecturer, @room)";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@day", cmbDay.Text);
            cmd.Parameters.AddWithValue("@time", txtTime.Text);
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text);
            cmd.Parameters.AddWithValue("@lecturer", txtLecturer.Text);
            cmd.Parameters.AddWithValue("@room", txtRoom.Text);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Timetable entry added.");
                LoadTimetable();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding entry: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridTimetable.Rows[e.RowIndex];
                selectedTimetableId = Convert.ToInt32(row.Cells["id"].Value);
                cmbDay.Text = row.Cells["day"].Value.ToString();
                txtTime.Text = row.Cells["time"].Value.ToString();
                txtSubject.Text = row.Cells["subject"].Value.ToString();
                txtLecturer.Text = row.Cells["lecturer"].Value.ToString();
                txtRoom.Text = row.Cells["room"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Select an entry to update.");
                return;
            }

            string query = "UPDATE timetable SET day=@day, time=@time, subject=@subject, lecturer=@lecturer, room=@room WHERE id=@id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@day", cmbDay.Text);
            cmd.Parameters.AddWithValue("@time", txtTime.Text);
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text);
            cmd.Parameters.AddWithValue("@lecturer", txtLecturer.Text);
            cmd.Parameters.AddWithValue("@room", txtRoom.Text);
            cmd.Parameters.AddWithValue("@id", selectedTimetableId);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Timetable entry updated.");
                LoadTimetable();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating entry: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Select an entry to delete.");
                return;
            }

            var confirm = MessageBox.Show("Delete this timetable entry?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            string query = "DELETE FROM timetable WHERE id=@id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", selectedTimetableId);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry deleted.");
                LoadTimetable();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting entry: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearForm()
        {
            cmbDay.SelectedIndex = -1;
            txtTime.Clear();
            txtSubject.Clear();
            txtLecturer.Clear();
            txtRoom.Clear();
            selectedTimetableId = -1;
        }
    }
}
