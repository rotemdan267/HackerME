using System;
using System.Collections.Generic;

namespace HackerMeDB2
{
    public class MyDB
    {
        public static StudentList Students { get; set; } = new StudentList();
        public static CourseList Courses { get; set; } = new CourseList();
        public static List<Student> StudentsSearched = new List<Student>();
    }
}
