using System;
using System.Collections.Generic;
using RESTAPI.Models;

namespace RESTAPI.Data 
{
   public interface ICourseData
   {
       List<Course> GetCourses();

       Course GetCourse(Guid coursenumber);

       Course AddCourse(Course course);

       void DeleteCourse(Course course);

       void UpdateCourse(Course course);


   } 
}