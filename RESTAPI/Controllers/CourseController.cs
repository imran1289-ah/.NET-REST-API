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
                //Return 200 for sucess
                return Ok(Course);
            }
            else
                //Return 404 for error
                return NotFound("Course with id "+id+" was not found");
        }

        //POST method to add a course
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCourse(Course course)
        {
            _coursedata.AddCourse(course);
            //return 201 for sucess
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + course.Id, course);
        }

        //Delete method to delete a course by id
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteCourse(Guid id)
        {
            var course = _coursedata.GetCourse(id);

            if (course != null)
            {
               _coursedata.DeleteCourse(course);
                //Return 200 for sucess
                return Ok();
            }
            else
                //Return 404 for error
                return NotFound("Course with id "+id+" was not found");

        }

        //Delete method to delete a course by id
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdateCourse(Guid id, Course course)
        {
            var Course = _coursedata.GetCourse(id);

            if (Course != null)
            {
                course.Id = Course.Id;
               _coursedata.UpdateCourse(course);

                //Return 200 for sucess
                return Ok();
            }
            else
                //Return 404 for error
                return NotFound("Course with id "+id+" was not found");

        }

    }
}