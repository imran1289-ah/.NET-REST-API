using Microsoft.EntityFrameworkCore;

namespace RESTAPI.Models
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options): base(options)
        {
            
        }


        //This will act as a table created in the database
        public DbSet<Course> Courses { get; set; }
    }
}