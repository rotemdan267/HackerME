using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerMeDB2
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public DateOnly DOB { get; set; }
        public int PhoneNum { get; set; }
        public string EmailAdress { get; set; }
        public string City { get; set; }
        public float AmountToPay { get; set; }
        public float AmountPaid { get; set; }
        public CourseList Courses { get; set; } = new CourseList();

        public override string ToString()
        {
            return $"ID: {Id}, First Name: {FirstName}, Last Name: {LastName}";
        }
    }
}
