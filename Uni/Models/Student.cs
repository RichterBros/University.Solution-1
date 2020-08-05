using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<StudentCourse>();
        }
        public int DepartmentId;
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<StudentCourse> Courses { get;} // has all Id's joined data which is associated to the caregory object
    }
}