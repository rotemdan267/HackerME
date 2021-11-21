namespace HackerME
{
    partial class NewStudent
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
            this.pnlSaveStudent = new System.Windows.Forms.Panel();
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlSaveStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSaveStudent
            // 
            this.pnlSaveStudent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlSaveStudent.Controls.Add(this.checkedListBox1);
            this.pnlSaveStudent.Controls.Add(this.btnSaveNewStudent);
            this.pnlSaveStudent.Controls.Add(this.comboBoxCity);
            this.pnlSaveStudent.Controls.Add(this.dateTimePicker1);
            this.pnlSaveStudent.Controls.Add(this.lblDOB);
            this.pnlSaveStudent.Controls.Add(this.lblCity);
            this.pnlSaveStudent.Controls.Add(this.txtEmail);
            this.pnlSaveStudent.Controls.Add(this.lblPhone);
            this.pnlSaveStudent.Controls.Add(this.lblEmail);
            this.pnlSaveStudent.Controls.Add(this.txtPhone);
            this.pnlSaveStudent.Controls.Add(this.txtLastName);
            this.pnlSaveStudent.Controls.Add(this.lblLastName);
            this.pnlSaveStudent.Controls.Add(this.txtFirstName);
            this.pnlSaveStudent.Controls.Add(this.lblCourses);
            this.pnlSaveStudent.Controls.Add(this.lblFirstName);
            this.pnlSaveStudent.Controls.Add(this.txtID);
            this.pnlSaveStudent.Controls.Add(this.lblID);
            this.pnlSaveStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSaveStudent.Location = new System.Drawing.Point(0, 0);
            this.pnlSaveStudent.Name = "pnlSaveStudent";
            this.pnlSaveStudent.Size = new System.Drawing.Size(614, 501);
            this.pnlSaveStudent.TabIndex = 2;
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
            this.checkedListBox1.Location = new System.Drawing.Point(348, 124);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 5;
            // 
            // btnSaveNewStudent
            // 
            this.btnSaveNewStudent.Location = new System.Drawing.Point(108, 318);
            this.btnSaveNewStudent.Name = "btnSaveNewStudent";
            this.btnSaveNewStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewStudent.TabIndex = 4;
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
            this.comboBoxCity.Location = new System.Drawing.Point(120, 211);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(169, 23);
            this.comboBoxCity.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(40, 243);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(76, 15);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(75, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 15);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(65, 156);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 15);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(65, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 153);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(169, 23);
            this.txtPhone.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 124);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 23);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(47, 127);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(348, 86);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(52, 15);
            this.lblCourses.TabIndex = 0;
            this.lblCourses.Text = "Courses:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(47, 98);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(75, 69);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID: ";
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSaveStudent);
            this.Name = "NewStudent";
            this.Size = new System.Drawing.Size(614, 501);
            this.pnlSaveStudent.ResumeLayout(false);
            this.pnlSaveStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSaveStudent;
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
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}
