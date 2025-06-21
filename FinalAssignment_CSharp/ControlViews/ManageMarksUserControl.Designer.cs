using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FinalAssignment_CSharp.ControlViews
{
    partial class ManageMarksUserControl
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
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridMarks = new System.Windows.Forms.DataGridView();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.labelMark = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.btnUpdateMark = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Computer Science",
            "Information Technology",
            "Software Engineering",
            "Cybersecurity",
            "Data Science"});
            this.cmbCourse.Location = new System.Drawing.Point(110, 20);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(300, 24);
            this.cmbCourse.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLoad.Location = new System.Drawing.Point(430, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Students";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridMarks
            // 
            this.dataGridMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMarks.Location = new System.Drawing.Point(20, 60);
            this.dataGridMarks.Name = "dataGridMarks";
            this.dataGridMarks.RowHeadersWidth = 51;
            this.dataGridMarks.RowTemplate.Height = 24;
            this.dataGridMarks.Size = new System.Drawing.Size(670, 400);
            this.dataGridMarks.TabIndex = 2;
            this.dataGridMarks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMarks_CellClick);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.labelCourse.Location = new System.Drawing.Point(20, 22);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(75, 22);
            this.labelCourse.TabIndex = 3;
            this.labelCourse.Text = "Course:";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.labelStudentId.Location = new System.Drawing.Point(720, 80);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(116, 22);
            this.labelStudentId.TabIndex = 4;
            this.labelStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(840, 80);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(150, 22);
            this.txtStudentId.TabIndex = 5;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.labelStudentName.Location = new System.Drawing.Point(720, 130);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(141, 22);
            this.labelStudentName.TabIndex = 6;
            this.labelStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(860, 130);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(250, 22);
            this.txtStudentName.TabIndex = 7;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.labelSubject.Location = new System.Drawing.Point(720, 180);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(82, 22);
            this.labelSubject.TabIndex = 8;
            this.labelSubject.Text = "Subject:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(810, 180);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(300, 24);
            this.cmbSubject.TabIndex = 9;
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.labelMark.Location = new System.Drawing.Point(720, 230);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(65, 22);
            this.labelMark.TabIndex = 10;
            this.labelMark.Text = "Mark:";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(780, 230);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 22);
            this.txtMark.TabIndex = 11;
            // 
            // btnAddMark
            // 
            this.btnAddMark.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddMark.Location = new System.Drawing.Point(720, 280);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(75, 28);
            this.btnAddMark.TabIndex = 12;
            this.btnAddMark.Text = "Add";
            this.btnAddMark.UseVisualStyleBackColor = false;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // btnUpdateMark
            // 
            this.btnUpdateMark.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateMark.Location = new System.Drawing.Point(815, 280);
            this.btnUpdateMark.Name = "btnUpdateMark";
            this.btnUpdateMark.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateMark.TabIndex = 13;
            this.btnUpdateMark.Text = "Update";
            this.btnUpdateMark.UseVisualStyleBackColor = false;
            this.btnUpdateMark.Click += new System.EventHandler(this.btnUpdateMark_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteMark.Location = new System.Drawing.Point(910, 280);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteMark.TabIndex = 14;
            this.btnDeleteMark.Text = "Delete";
            this.btnDeleteMark.UseVisualStyleBackColor = false;
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // ManageMarksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteMark);
            this.Controls.Add(this.btnUpdateMark);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.dataGridMarks);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbCourse);
            this.Name = "ManageMarksUserControl";
            this.Size = new System.Drawing.Size(1130, 480);
            this.Load += new System.EventHandler(this.ManageMarksUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            string selectedCourse = cmbCourse.SelectedItem.ToString();

            string query = "SELECT id, student_number, name FROM students WHERE course = @course";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@course", selectedCourse);

            connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            dataGridMarks.DataSource = dt;
        }

        private void dataGridMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridMarks.Rows[e.RowIndex];
                txtStudentId.Text = row.Cells["student_id"].Value.ToString();
                txtStudentName.Text = row.Cells["student_name"].Value.ToString();
                cmbSubject.SelectedItem = row.Cells["subject"].Value.ToString();
                txtMark.Text = row.Cells["mark"].Value.ToString();
            }
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            string course = cmbCourse.SelectedItem?.ToString();
            string studentId = txtStudentId.Text.Trim();
            string studentName = txtStudentName.Text.Trim();
            string subject = cmbSubject.SelectedItem?.ToString();
            string markText = txtMark.Text.Trim();

            if (string.IsNullOrEmpty(course) || string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(studentName)
                || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(markText))
            {
                MessageBox.Show("Please fill all the fields before submitting.");
                return;
            }

            int mark = int.Parse(markText); // this will crash if not a number, so be sure only numbers allowed

            string query = "INSERT INTO marks (student_id, student_name, course, subject, mark) VALUES (@sid, @sname, @course, @subject, @mark)";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@sid", studentId);
            cmd.Parameters.AddWithValue("@sname", studentName);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@mark", mark);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Mark added successfully!");
            btnLoad_Click(null, null); // reload grid
        }

        private void btnUpdateMark_Click(object sender, EventArgs e)
        {
            if (dataGridMarks.CurrentRow == null)
            {
                MessageBox.Show("Select a mark entry to update.");
                return;
            }

            int markId = Convert.ToInt32(dataGridMarks.CurrentRow.Cells["id"].Value);
            string subject = cmbSubject.SelectedItem?.ToString();
            int mark = int.Parse(txtMark.Text.Trim());

            string query = "UPDATE marks SET subject = @subject, mark = @mark WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.Parameters.AddWithValue("@subject", subject);
            cmd.Parameters.AddWithValue("@mark", mark);
            cmd.Parameters.AddWithValue("@id", markId);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Mark updated!");
            btnLoad_Click(null, null); // Reload table
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            if (dataGridMarks.CurrentRow == null)
            {
                MessageBox.Show("Select a mark entry to delete.");
                return;
            }

            int markId = Convert.ToInt32(dataGridMarks.CurrentRow.Cells["id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM marks WHERE id = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", markId);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Mark deleted.");
                btnLoad_Click(null, null); // Refresh the table
            }
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridMarks;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.Button btnUpdateMark;
        private System.Windows.Forms.Button btnDeleteMark;
    }
}
