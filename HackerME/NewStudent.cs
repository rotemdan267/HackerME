using HackerMeDB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerME
{
    public partial class NewStudent : UserControl
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnSaveNewStudent_Click(object sender, EventArgs e)
        {

            Student student = new Student();
            int id;
            bool isValidStudent = true;
            string errorMessage = "";
            if (!int.TryParse(txtID.Text, out id))
            {
                isValidStudent = false;
                errorMessage += "ID must be numbers only\n";
            }
            Regex nameRegex = new Regex(@"\D{2,}");
            if (!nameRegex.IsMatch(txtFirstName.Text))
            {
                isValidStudent = false;
                errorMessage += "First name must be at least 2 letters, and can contain only english letters\n";
            }
            if (!nameRegex.IsMatch(txtLastName.Text))
            {
                isValidStudent = false;
                errorMessage += "Last name must be at least 2 letters, and can contain only english letters\n";
            }
            Regex phoneRegex = new Regex(@"[0]{1}[0-9]{8,9}");
            if (!phoneRegex.IsMatch(txtPhone.Text))
            {
                isValidStudent = false;
                errorMessage += "Invalid Israeli phone number\n";
            }
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (!emailRegex.IsMatch(txtEmail.Text))
            {
                isValidStudent = false;
                errorMessage += "Invalid email address\n";
            }
            CheckedListBox.CheckedItemCollection list = checkedListBox1.CheckedItems;
            if (list.Count == 0)
            {
                isValidStudent = false;
                errorMessage += "Student must sign at least to 1 course\n";
            }
            if (isValidStudent)
            {

                student.Id = id;
                student.FirstName = txtFirstName.Text;
                student.LastName = txtLastName.Text;
                student.PhoneNum = int.Parse(txtPhone.Text);
                student.EmailAdress = txtEmail.Text;
                student.City = comboBoxCity.Text;
                student.DOB = DateOnly.FromDateTime(dateTimePicker1.Value);
                foreach (var item in list)
                {
                    student.Courses.Add(new Course(item.ToString()));
                }

                MyDB.Students.Add(student);
                MessageBox.Show("Student added successfully");
            }
            else MessageBox.Show(errorMessage);

        }
    }
}
