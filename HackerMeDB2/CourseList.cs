using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerMeDB2
{
    public class CourseList
    {
        public List<CourseWithGrade> Courses { get; set; } = new List<CourseWithGrade>();
        public CourseList()
        {
        }
        public CourseList(List<CourseWithGrade> courses)
        {
            Courses = courses;
        }
        public CourseList(Course course1, Course course2)
        {
            Courses.Add(new CourseWithGrade(course1));
            Courses.Add(new CourseWithGrade(course2));
        }

        public void Add(CourseWithGrade course)
        {
            Courses.Add(course);
        }
        public void Add(Course course)
        {
            CourseWithGrade cwg = new CourseWithGrade(course);
            Courses.Add(cwg);
        }
        public void Remove(CourseWithGrade course)
        {
            Courses.Remove(course);
        }
        public override string ToString()
        {
            string str = "";
            foreach (CourseWithGrade course in Courses)
            {
                str += course.course.Name + " " + course.grade.Grade + ". ";
            }
            return str;
        }
    }
}
