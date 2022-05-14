using System;

namespace RESTAPI.Models
{
    public class Course
    {
        //Data for a course
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public int CourseNumber { get; set; }
        public string CourseDepartment { get; set; }
        public double CourseCredits { get; set; }
        public string CourseInstructor { get; set; }
    }
}