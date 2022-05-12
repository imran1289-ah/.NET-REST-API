using System;
using System.Collections.Generic;
using System.Linq;
using RESTAPI.Models;

namespace RESTAPI.Data
{
    public class SqlCourseData : ICourseData
    {

        private CourseContext _courseContext;

        public SqlCourseData(CourseContext courseContext)
        {
            _courseContext = courseContext;
            
        }

        public Course AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(Guid id)
        {
            var course = _courseContext.Courses.Find(id);
            return course;
        }

        public List<Course> GetCourses()
        {
            return _courseContext.Courses.ToList();
        }

        public void UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}