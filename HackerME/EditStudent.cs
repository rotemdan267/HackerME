using HackerMeDB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerME
{
    public partial class EditStudent : UserControl
    {
        public int Index { get; set; }
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnSelectToSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (var item in MyDB.Students.Students)
            {
                ids.Add(item.Id);
            }
            comboBoxSearchBy.DataSource = ids;
            btnSaveNewStudent.Visible = false;
            btnDelete.Visible = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectToSearch_Click_1(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(comboBoxSearchBy.Text, out id))
            {
                Index = MyDB.Students.SearchStudentByID(id);
            }
            else MessageBox.Show("ID must be numbers only");
            if (Index != -1)
            {
                txtFirstName.Text = MyDB.Students.Students[Index].FirstName;
                txtLastName.Text = MyDB.Students.Students[Index].LastName;
                txtPhone.Text = MyDB.Students.Students[Index].PhoneNum.ToString();
                txtEmail.Text = MyDB.Students.Students[Index].EmailAdress;
                comboBoxCity.Text = MyDB.Students.Students[Index].City;
                dateTimePicker1.Value = MyDB.Students.Students[Index].DOB.ToDateTime(TimeOnly.MinValue);
                var list = checkedListBox1.Items;
                for (int i = 0; i < list.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    foreach (var course in MyDB.Students.Students[Index].Courses.Courses)
                    {
                        if (list[i].ToString() == course.course.Name)
                        {
                            checkedListBox1.SetItemChecked(i, true);
                        }
                    }
                }


            }
            else MessageBox.Show("You've entered wrong ID");
            btnSaveNewStudent.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnSaveNewStudent_Click(object sender, EventArgs e)
        {
            MyDB.Students.Students[Index].FirstName = txtFirstName.Text;
            MyDB.Students.Students[Index].LastName = txtLastName.Text;
            int phone;
            if (int.TryParse(txtPhone.Text, out phone))
            {
                MyDB.Students.Students[Index].PhoneNum = phone;
            }
            else MessageBox.Show("Phone must be numbers only");
            MyDB.Students.Students[Index].EmailAdress = txtEmail.Text;
            MyDB.Students.Students[Index].City = comboBoxCity.Text;
            MyDB.Students.Students[Index].DOB = DateOnly.FromDateTime(dateTimePicker1.Value);
            var list = checkedListBox1.Items;
            bool add = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    foreach (var item in MyDB.Students.Students[Index].Courses.Courses)
                    {
                        if (list[i].ToString() == item.course.Name)
                        {
                            add = false;
                        }
                    }
                    if (add)
                    {
                        MyDB.Students.Students[Index].Courses.Add(new Course(list[i].ToString()));
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {MyDB.Students.Students[Index].FirstName}?", "Delete Student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MyDB.Students.Remove(MyDB.Students.Students[Index]);
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void btnEditGrades_Click(object sender, EventArgs e)
        {
            EditGrades editGrades = new EditGrades(Index);
            Program.hackerMe.SwitchUserControl(editGrades);
        }
    }
}
