using System.Collections.Generic;
using RESTAPI.Models;
using System;

namespace RESTAPI.Data
{
    public class MockCourse : ICourseData
    {

        //Random Courses to Test API
        private List<Course> Courses = new List<Course>() 
        {
            new Course(){Id=Guid.NewGuid(),CourseName="Operating Systems", CourseNumber=346, CourseDepartment="COMP", CourseCredits=4, CourseInstructor="James Williams" },
            new Course(){Id=Guid.NewGuid(), CourseName="Differential Equations", CourseNumber=213, CourseDepartment="ENGR", CourseCredits=3, CourseInstructor="Kevin John" },
            new Course(){Id=Guid.NewGuid(), CourseName="Principles of Electrical Engineering", CourseNumber=275, CourseDepartment="ELEC", CourseCredits=3.5, CourseInstructor="Alex Lu" }

        };

        public Course AddCourse(Course course)
        {
            course.Id = Guid.NewGuid();
            Courses.Add(course);
            return course;
        }

        public void DeleteCourse(Course course)
        {
            throw new System.NotImplementedException();
        }

        //Get Course by Id
        public Course GetCourse(Guid coursenumber)
        {
            return Courses.Find(x => x.Id == coursenumber);
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