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
    public partial class RegisterUserControl : UserControl
    {

        private SQLiteConnection connection;
        private int selectedUserId = -1;
        public RegisterUserControl(SQLiteConnection conn)
        {
            InitializeComponent();
            connection = conn;
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT id, name, email, role FROM users";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query,connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridUsers.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            string query = "INSERT INTO users (name, email, password, role, created_at, updated_at) VALUES (@name, @email, @pass, @role, @cAt, @uAt)";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@cAt", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@uAt", DateTime.Now.ToString());

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("User added successfully.");
            LoadUsers();
            ClearForm();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1) return;

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.Text;

            string query = "UPDATE users SET name = @name, email = @email, role = @role, updated_at = @uAt WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@uAt", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@id", selectedUserId);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("User updated.");
            LoadUsers();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1) return;

            string query = "DELETE FROM users WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", selectedUserId);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("User deleted.");
            LoadUsers();
            ClearForm();
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
                    txtEmail.Text = row.Cells["email"].Value.ToString();
                    cmbRole.Text = row.Cells["role"].Value.ToString();

                    // Debug
                    MessageBox.Show("Selected ID = " + selectedUserId);
                }
                else
                {
                    MessageBox.Show("Selected row has no ID value.");
                }
            }
        }


        private void ClearForm()
        {
            txtName.Text = txtEmail.Text = txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            selectedUserId = -1;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = "INSERT INTO users (name, email, password, role, created_at, updated_at) VALUES (@name, @email, @pass, @role, @cAt, @uAt)";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@cAt", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@uAt", DateTime.Now.ToString());

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
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
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields before updating.");
                return;
            }

            string query = "UPDATE users SET name = @name, email = @email, role = @role, updated_at = @uAt WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
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
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
