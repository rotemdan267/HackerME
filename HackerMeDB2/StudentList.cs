using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerMeDB2
{
    public class StudentList
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void Add(Student student)
        {
            Students.Add(student);
        }
        public void Remove(Student student)
        {
            Students.Remove(student);
        }
        public int SearchStudentByID(int id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id==id)
                {
                    return i;
                }
            } 
            return -1;
        }
        public List<Student> SearchStudent(Student stu, string category)
        {
            List<Student> students = new List<Student>();
            switch (category)
            {
                case "ID":
                    foreach (Student student in Students)
                    {
                        if (student.Id == stu.Id)
                        {
                            students.Add(student);
                        }
                    }
                    break;
                case "First Name":
                    foreach (Student student in Students)
                    {
                        if (student.FirstName == stu.FirstName)
                        {
                            students.Add(student);
                        }
                    }
                    break;
                case "Last Name":
                    foreach (Student student in Students)
                    {
                        if (student.LastName == stu.LastName)
                        {
                            students.Add(student);
                        }
                    }
                    break;
                case "Phone":
                    foreach (Student student in Students)
                    {
                        if (student.PhoneNum == stu.PhoneNum)
                        {
                            students.Add(student);
                        }
                    }
                    break;
                case "Email":
                    foreach (Student student in Students)
                    {
                        if (student.EmailAdress == stu.EmailAdress)
                        {
                            students.Add(student);
                        }
                    }
                    break;
                case "City":
                    foreach (Student student in Students)
                    {
                        if (student.City == stu.City)
                        {
                            students.Add(student);
                        }
                    }
                    break;
                case "Date of Birth":
                    foreach (Student student in Students)
                    {
                        if (student.DOB == stu.DOB)
                        {
                            students.Add(student);
                        }
                    }
                    break;
            }
            return students;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
