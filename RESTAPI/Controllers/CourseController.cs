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

    }
}