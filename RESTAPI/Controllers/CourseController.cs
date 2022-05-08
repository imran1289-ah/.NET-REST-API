using Microsoft.AspNetCore.Mvc;
using RESTAPI.Data;

namespace RESTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private ICourseData _coursedata;
        public CourseController(ICourseData coursedata)
        {
            _coursedata = coursedata;
        }

        //GET method to get all courses
        
    }
}