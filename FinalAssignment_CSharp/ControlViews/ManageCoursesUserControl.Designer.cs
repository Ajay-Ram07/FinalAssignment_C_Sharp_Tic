using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FinalAssignment_CSharp.ControlViews
{
    partial class ManageCoursesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.labelLecturer = new System.Windows.Forms.Label();
            this.txtLecturer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(30, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(71, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(150, 20);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(250, 22);
            this.txtStudentId.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(150, 60);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(250, 22);
            this.txtStudentName.TabIndex = 3;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(30, 100);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(53, 16);
            this.labelCourse.TabIndex = 4;
            this.labelCourse.Text = "Course:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Computer Science",
            "Software Engineering",
            "Information Technology",
            "Cybersecurity",
            "Data Science"});
            this.cmbCourse.Location = new System.Drawing.Point(150, 100);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(250, 24);
            this.cmbCourse.TabIndex = 5;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // labelLecturer
            // 
            this.labelLecturer.AutoSize = true;
            this.labelLecturer.Location = new System.Drawing.Point(30, 140);
            this.labelLecturer.Name = "labelLecturer";
            this.labelLecturer.Size = new System.Drawing.Size(58, 16);
            this.labelLecturer.TabIndex = 6;
            this.labelLecturer.Text = "Lecturer:";
            // 
            // txtLecturer
            // 
            this.txtLecturer.Location = new System.Drawing.Point(150, 140);
            this.txtLecturer.Name = "txtLecturer";
            this.txtLecturer.Size = new System.Drawing.Size(250, 22);
            this.txtLecturer.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToAddRows = false;
            this.dataGridStudents.AllowUserToDeleteRows = false;
            this.dataGridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(30, 240);
            this.dataGridStudents.MultiSelect = false;
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.ReadOnly = true;
            this.dataGridStudents.RowHeadersWidth = 51;
            this.dataGridStudents.RowTemplate.Height = 24;
            this.dataGridStudents.Size = new System.Drawing.Size(700, 300);
            this.dataGridStudents.TabIndex = 11;
            this.dataGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellClick);
            this.dataGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellContentClick);
            // 
            // ManageCoursesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.labelLecturer);
            this.Controls.Add(this.txtLecturer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridStudents);
            this.Name = "ManageCoursesUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.ManageMarksUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtStudentId.Text.Trim();
            string name = txtStudentName.Text.Trim();
            string course = cmbCourse.Text.Trim();
            string lecturer = txtLecturer.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query = "INSERT INTO marks (student_id, student_name, course_name, lecturer, created_at, updated_at) VALUES (@id, @name, @course, @lecturer, @created, @updated)";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@lecturer", lecturer);
            cmd.Parameters.AddWithValue("@created", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@updated", DateTime.Now.ToString());

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Mark record added.");
            LoadMarks();
            ClearForm();
        }

        private int selectedMarkId = -1;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text) || cmbCourse.SelectedItem == null)
            {
                MessageBox.Show("Please select a student and a course.");
                return;
            }

            int id = Convert.ToInt32(txtStudentId.Text);
            string course = cmbCourse.SelectedItem.ToString();

            string query = "UPDATE students SET course = @course WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@id", id);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Course updated successfully.");
            LoadStudents(); // Refresh the grid
        
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Select a record to delete.");
                return;
            }

            string query = "DELETE FROM marks WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", selectedMarkId);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Mark record deleted.");
            LoadMarks();
            ClearForm();
        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridStudents.Rows[e.RowIndex];

                txtStudentId.Text = row.Cells["id"].Value.ToString(); // correct
                txtStudentName.Text = row.Cells["name"].Value.ToString(); // correct
                cmbCourse.Text = row.Cells["course"].Value.ToString(); // correct
            }
        }


        private void ClearForm()
        {
            txtStudentId.Text = "";
            txtStudentName.Text = "";
            cmbCourse.SelectedIndex = -1;
            txtLecturer.Text = "";
            selectedMarkId = -1;
        }


        private void ManageMarksUserControl_Load(object sender, EventArgs e)
        {
            LoadCoursesIntoComboBox();
            LoadStudents();
            LoadCoursesIntoComboBox();
            //LoadMarks();
        }

        private void LoadStudents()
        {
            string query = "SELECT id, name, course FROM students";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridStudents.DataSource = dt;
        }

        private void LoadCoursesIntoComboBox()
        {
            cmbCourse.Items.Clear();
            string query = "SELECT course_name FROM courses";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);

            connection.Open();
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbCourse.Items.Add(reader["course_name"].ToString());
                }
            }
            connection.Close();
        }



        private void LoadMarks()
        {
            string query = "SELECT * FROM marks"; // Adjust if needed
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridStudents.DataSource = dt;
        }



        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label labelLecturer;
        private System.Windows.Forms.TextBox txtLecturer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridStudents;



        #endregion
    }
}
