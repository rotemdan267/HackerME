using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerMeDB2
{
    public class GradeClass
    {
        public int Grade { get; set; }

        public GradeClass(int grade)
        {
            Grade = grade;
        }
    }
    public struct CourseWithGrade
    {
        public Course course = new Course();
        public GradeClass grade;

        public CourseWithGrade(Course course) : this()
        {
            this.course = course;
            this.grade = new GradeClass(0);
        }

        public CourseWithGrade(Course course, GradeClass grade)
        {
            this.course = course;
            this.grade = grade;
        }
    }
    public class Course
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateOnly CourseStart { get; set; }
        public int NumOfLessons { get; set; }

        public Course()
        {

        }
        public Course(string name)
        {
            Name = name;
        }
        public Course(string iD, string name, DateOnly courseStart, int numOfLessons)
        {
            ID = iD;
            Name = name;
            CourseStart = courseStart;
            NumOfLessons = numOfLessons;
        }
    }
}
