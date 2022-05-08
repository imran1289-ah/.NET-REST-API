using System.Collections.Generic;
using RESTAPI.Models;

namespace RESTAPI.Data
{
    public class MockCourse : ICourseData
    {

        //Random Courses to Test API
        private List<Course> Courses = new List<Course>() 
        {
            new Course{CourseName="Operating Systems", CourseNumber=346, CourseDepartment="COMP", CourseCredits=4, CourseInstructor="James Williams" },
            new Course{CourseName="Differential Equations", CourseNumber=213, CourseDepartment="ENGR", CourseCredits=3, CourseInstructor="Kevin John" },
            new Course{CourseName="Principles of Electrical Engineering", CourseNumber=275, CourseDepartment="ELEC", CourseCredits=3.5, CourseInstructor="Alex Lu" }

        };

        public Course AddCourse(Course course)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCourse(Course course)
        {
            throw new System.NotImplementedException();
        }

        public Course GetCourse(int coursenumber)
        {
            throw new System.NotImplementedException();
        }

        //Get all Courses
        public List<Course> GetCourses()
        {
            return Courses;
        }

        public void UpdateCourse(Course course)
        {
            throw new System.NotImplementedException();
        }
    }
}