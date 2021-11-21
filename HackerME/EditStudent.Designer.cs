namespace HackerME
{
    partial class EditStudent
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
            this.components = new System.ComponentModel.Container();
            this.myDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnSaveNewStudent = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSelectToSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditGrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDBBindingSource
            // 
            this.myDBBindingSource.DataSource = typeof(HackerMeDB2.MyDB);
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataSource = typeof(HackerMeDB2.StudentList);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            ".NET Basic",
            "HTML",
            "CSS",
            "Core",
            "OOP"});
            this.checkedListBox1.Location = new System.Drawing.Point(432, 181);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 22;
            // 
            // btnSaveNewStudent
            // 
            this.btnSaveNewStudent.Location = new System.Drawing.Point(192, 375);
            this.btnSaveNewStudent.Name = "btnSaveNewStudent";
            this.btnSaveNewStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewStudent.TabIndex = 21;
            this.btnSaveNewStudent.Text = "Save";
            this.btnSaveNewStudent.UseVisualStyleBackColor = true;
            this.btnSaveNewStudent.Click += new System.EventHandler(this.btnSaveNewStudent_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Jerusalen",
            "Tel Aviv",
            "Holon",
            "Ramat Gan",
            "Bat Yam",
            "Rishon Lezion"});
            this.comboBoxCity.Location = new System.Drawing.Point(204, 268);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(168, 23);
            this.comboBoxCity.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 23);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(124, 300);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(76, 15);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(159, 271);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 15);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(204, 239);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 23);
            this.txtEmail.TabIndex = 14;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(149, 213);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 15);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(149, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(204, 210);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 23);
            this.txtPhone.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(204, 181);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 23);
            this.txtLastName.TabIndex = 17;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(131, 184);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(204, 152);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 23);
            this.txtFirstName.TabIndex = 18;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(432, 143);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(52, 15);
            this.lblCourses.TabIndex = 8;
            this.lblCourses.Text = "Courses:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(131, 155);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(141, 64);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(126, 15);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Select the student\'s ID:";
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Location = new System.Drawing.Point(283, 61);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSearchBy.TabIndex = 23;
            // 
            // btnSelectToSearch
            // 
            this.btnSelectToSearch.Location = new System.Drawing.Point(449, 61);
            this.btnSelectToSearch.Name = "btnSelectToSearch";
            this.btnSelectToSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSelectToSearch.TabIndex = 24;
            this.btnSelectToSearch.Text = "Select";
            this.btnSelectToSearch.UseVisualStyleBackColor = true;
            this.btnSelectToSearch.Click += new System.EventHandler(this.btnSelectToSearch_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditGrades
            // 
            this.btnEditGrades.Location = new System.Drawing.Point(449, 300);
            this.btnEditGrades.Name = "btnEditGrades";
            this.btnEditGrades.Size = new System.Drawing.Size(75, 23);
            this.btnEditGrades.TabIndex = 26;
            this.btnEditGrades.Text = "Edit Grades";
            this.btnEditGrades.UseVisualStyleBackColor = true;
            this.btnEditGrades.Click += new System.EventHandler(this.btnEditGrades_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditGrades);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectToSearch);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnSaveNewStudent);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Name = "EditStudent";
            this.Size = new System.Drawing.Size(676, 521);
            this.Load += new System.EventHandler(this.EditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource myDBBindingSource;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnSaveNewStudent;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button btnSelectToSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditGrades;
    }
}
