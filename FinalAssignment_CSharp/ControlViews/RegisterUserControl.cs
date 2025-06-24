using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FinalAssignment_CSharp.ControlViews
{
    public partial class RegisterUserControl : UserControl
    {
        private SQLiteConnection connection;
        private int selectedUserId = -1;

        // Change this as needed or get dynamically from UI
        private string defaultCourseForStudent = "Data Science";

        public RegisterUserControl(SQLiteConnection conn)
        {
            InitializeComponent();
            connection = conn;
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT id, name, role FROM users";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridUsers.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = "INSERT INTO users (name, password, role, created_at, updated_at) VALUES (@name, @pass, @role, @cAt, @uAt)";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@cAt", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@uAt", DateTime.Now.ToString());

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

                //Get the last inserted user ID
                long userId = connection.LastInsertRowId;

                if (role.ToLower() == "student")
                {
                    string course = defaultCourseForStudent; // Or get dynamically

                    // Insert into students table with course
                    string studentInsert = "INSERT INTO students (name, course) VALUES (@name, @course)";
                    SQLiteCommand studentCmd = new SQLiteCommand(studentInsert, connection);
                    studentCmd.Parameters.AddWithValue("@name", name);
                    studentCmd.Parameters.AddWithValue("@course", course);
                    studentCmd.ExecuteNonQuery();

                    //Get the student_id back (auto-generated ID)
                    long newStudentId = connection.LastInsertRowId;

                    // Add a default subject and mark to the 'marks' table (optional)
                    string defaultSubject = "Introduction";
                    int defaultMark = 0;

                    string markInsert = "INSERT INTO marks (student_id, student_name, course, subject, mark) VALUES (@sid, @sname, @course, @subject, @mark)";
                    SQLiteCommand markCmd = new SQLiteCommand(markInsert, connection);
                    markCmd.Parameters.AddWithValue("@sid", newStudentId);
                    markCmd.Parameters.AddWithValue("@sname", name);
                    markCmd.Parameters.AddWithValue("@course", course);
                    markCmd.Parameters.AddWithValue("@subject", defaultSubject);
                    markCmd.Parameters.AddWithValue("@mark", defaultMark);
                    markCmd.ExecuteNonQuery();
                }
                else if (role.ToLower() == "lecturer")
                {
                    string lecturerInsert = "INSERT INTO lecturers (user_id, name, department) VALUES (@userId, @name, '')";
                    SQLiteCommand lecCmd = new SQLiteCommand(lecturerInsert, connection);
                    lecCmd.Parameters.AddWithValue("@userId", userId);
                    lecCmd.Parameters.AddWithValue("@name", name);
                    lecCmd.ExecuteNonQuery();
                }
                else if (role.ToLower() == "staff")
                {
                    string staffInsert = "INSERT INTO staff (user_id, name, position) VALUES (@userId, @name, '')";
                    SQLiteCommand staffCmd = new SQLiteCommand(staffInsert, connection);
                    staffCmd.Parameters.AddWithValue("@userId", userId);
                    staffCmd.Parameters.AddWithValue("@name", name);
                    staffCmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            string name = txtName.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields before updating.");
                return;
            }

            string query = "UPDATE users SET name = @name, role = @role, updated_at = @uAt WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@uAt", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@id", selectedUserId);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string query = "DELETE FROM users WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", selectedUserId);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridUsers.Rows[e.RowIndex];

                if (row.Cells["id"].Value != null)
                {
                    selectedUserId = Convert.ToInt32(row.Cells["id"].Value);
                    txtName.Text = row.Cells["name"].Value.ToString();
                    cmbRole.Text = row.Cells["role"].Value.ToString();
                }
            }
        }

        private void ClearForm()
        {
            txtName.Text = txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            selectedUserId = -1;
        }
    }
}
