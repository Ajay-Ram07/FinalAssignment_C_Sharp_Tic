namespace FinalAssignment_CSharp.ControlViews
{
    partial class TimetableUserControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtLecturer;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.DataGridView dataGridTimetable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

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

        private void InitializeComponent()
        {
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtLecturer = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.dataGridTimetable = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cmbDay.Location = new System.Drawing.Point(20, 20);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(150, 24);
            this.cmbDay.TabIndex = 0;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(190, 20);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(120, 22);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "Time";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(330, 20);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(150, 22);
            this.txtSubject.TabIndex = 2;
            this.txtSubject.Text = "subject";
            // 
            // txtLecturer
            // 
            this.txtLecturer.Location = new System.Drawing.Point(500, 20);
            this.txtLecturer.Name = "txtLecturer";
            this.txtLecturer.Size = new System.Drawing.Size(150, 22);
            this.txtLecturer.TabIndex = 3;
            this.txtLecturer.Text = "Lecturer";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(670, 20);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 22);
            this.txtRoom.TabIndex = 4;
            this.txtRoom.Text = "Room";
            // 
            // dataGridTimetable
            // 
            this.dataGridTimetable.AllowUserToAddRows = false;
            this.dataGridTimetable.AllowUserToDeleteRows = false;
            this.dataGridTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTimetable.Location = new System.Drawing.Point(20, 60);
            this.dataGridTimetable.MultiSelect = false;
            this.dataGridTimetable.Name = "dataGridTimetable";
            this.dataGridTimetable.ReadOnly = true;
            this.dataGridTimetable.RowHeadersWidth = 51;
            this.dataGridTimetable.RowTemplate.Height = 24;
            this.dataGridTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTimetable.Size = new System.Drawing.Size(760, 400);
            this.dataGridTimetable.TabIndex = 5;
            this.dataGridTimetable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTimetable_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TimetableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtLecturer);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.dataGridTimetable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Name = "TimetableUserControl";
            this.Size = new System.Drawing.Size(800, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
