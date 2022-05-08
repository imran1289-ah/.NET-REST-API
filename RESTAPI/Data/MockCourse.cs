using System.Collections.Generic;
using RESTAPI.Models;

namespace RESTAPI.Data
{
    public class MockCourse : ICourseData
    {
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

        public List<Course> GetCourses()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            throw new System.NotImplementedException();
        }
    }
}