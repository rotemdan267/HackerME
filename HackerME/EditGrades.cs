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
    public partial class EditGrades : UserControl
    {
        public int Index { get; set; }
        public EditGrades(int index)
        {
            InitializeComponent();
            this.Index = index;
        }

        private void EditGrades_Load(object sender, EventArgs e)
        {
            txtStudent.Text = $"Student: {MyDB.Students.Students[Index].Id.ToString()}, {MyDB.Students.Students[Index].FirstName} {MyDB.Students.Students[Index].LastName}";
            txtDotNet.Visible = false;
            txtHTML.Visible = false;
            txtCore.Visible = false;
            txtCSS.Visible = false;
            txtOOP.Visible = false;

            foreach (var item in MyDB.Students.Students[Index].Courses.Courses)
            {
                switch (item.course.Name)
                {
                    case ".NET Basic":
                        txtDotNet.Visible = true;
                        txtDotNet.Text = item.grade.Grade.ToString();
                        break;

                    case "HTML":
                        txtHTML.Visible = true;
                        txtHTML.Text = item.grade.Grade.ToString();
                        break;

                    case "CSS":
                        txtCSS.Visible = true;
                        txtCSS.Text = item.grade.Grade.ToString();
                        break;

                    case "Core":
                        txtCore.Visible = true;
                        txtCore.Text = item.grade.Grade.ToString();
                        break;

                    case "OOP":
                        txtOOP.Visible = true;
                        txtOOP.Text = item.grade.Grade.ToString();
                        break;

                    default:
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var item in MyDB.Students.Students[Index].Courses.Courses)
            {
                int grade = 0;
                bool isValidGrade = true;
                switch (item.course.Name)
                {
                    case ".NET Basic":
                        isValidGrade = int.TryParse(txtDotNet.Text, out grade);
                        if (isValidGrade)
                        {
                            item.grade.Grade = grade;
                        }
                        else MessageBox.Show("Grade must be numbers only");
                        break;

                    case "HTML":
                        isValidGrade = int.TryParse(txtHTML.Text, out grade);
                        if (isValidGrade)
                        {
                            item.grade.Grade = grade;
                        }
                        else MessageBox.Show("Grade must be numbers only");
                        break;

                    case "CSS":
                        isValidGrade = int.TryParse(txtCSS.Text, out grade);
                        if (isValidGrade)
                        {
                            item.grade.Grade = grade;
                        }
                        else MessageBox.Show("Grade must be numbers only");
                        break;

                    case "Core":
                        isValidGrade = int.TryParse(txtCore.Text, out grade);
                        if (isValidGrade)
                        {
                            item.grade.Grade = grade;
                        }
                        else MessageBox.Show("Grade must be numbers only");
                        break;

                    case "OOP":
                        isValidGrade = int.TryParse(txtOOP.Text, out grade);
                        if (isValidGrade)
                        {
                            item.grade.Grade = grade;
                        }
                        else MessageBox.Show("Grade must be numbers only");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
