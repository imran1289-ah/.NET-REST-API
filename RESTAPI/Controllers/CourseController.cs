using Microsoft.AspNetCore.Mvc;
using RESTAPI.Data;

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
        public IActionResult GetCourseById(int id)
        {
            var Course = _coursedata.GetCourse(id);

            if (Course != null)
            {
                return Ok(Course);
            }
            else
                return NotFound("Course with id "+id+" was not found");
        }

    }
}