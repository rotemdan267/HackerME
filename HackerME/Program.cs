using HackerMeDB2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HackerME
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Course course1 = new Course(".NET Basic");
            MyDB.Courses.Add(course1);
            Course course2 = new Course("HTML");
            MyDB.Courses.Add(course2);
            Course course3 = new Course("CSS");
            MyDB.Courses.Add(course3);
            Course course4 = new Course("Core");
            MyDB.Courses.Add(course4);
            Course course5 = new Course("OOP");
            MyDB.Courses.Add(course5);

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Moshe",
                LastName = "Cohen",
                PhoneNum = 123,
                EmailAdress = "moshe@gmail.com",
                City = "Holon",
                DOB = new DateOnly(1997, 6, 10),
                Courses = new CourseList(course3, course4)
            };
            MyDB.Students.Add(student);

            student = new Student()
            {
                Id = 234,
                FirstName = "Rotem",
                LastName = "Dan",
                PhoneNum = 987654,
                EmailAdress = "rotem@gmail.com",
                City = "Ramat Gan",
                DOB = new DateOnly(1992, 10, 23),
                Courses = new CourseList(course1, course2)
            };
            MyDB.Students.Add(student);

            student = new Student()
            {
                Id = 7654,
                FirstName = "Itay",
                LastName = "Dan",
                PhoneNum = 453015,
                EmailAdress = "itay@gmail.com",
                City = "Bat Yam",
                DOB = new DateOnly(1996, 11, 21),
                Courses = new CourseList(course4, course5)
            };
            MyDB.Students.Add(student);

            ApplicationConfiguration.Initialize();
            Application.Run(hackerMe);
        }
        static internal HackerMe hackerMe = new HackerMe();
    }
}
