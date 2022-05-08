using System;
using Microsoft.AspNetCore.Mvc;
using RESTAPI.Data;
using RESTAPI.Models;

namespace RESTAPI.Controllers
{
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseData _coursedata;
        public CourseController(ICourseData coursedata)
        {
            _coursedata = coursedata;
        }

        //GET method to get all courses
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCourses()
        {
            return Ok(_coursedata.GetCourses());
        }

        //GET method to get a course by id
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetCourseById(Guid id)
        {
            var Course = _coursedata.GetCourse(id);

            if (Course != null)
            {
                //Return 200
                return Ok(Course);
            }
            else
                //Return 404
                return NotFound("Course with id "+id+" was not found");
        }

        //POST method to add a course
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCourse(Course course)
        {
            _coursedata.AddCourse(course);
            //return 201
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + course.Id, course);
        }

    }
}