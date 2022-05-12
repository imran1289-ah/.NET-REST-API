using System;
using System.ComponentModel.DataAnnotations;

namespace RESTAPI.Models
{
    public class Course
    {
        //Data for a course

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Only 50 characthers is possible, Please try again")]
        public string CourseName { get; set; }

        [Required]
        [MaxLength(7, ErrorMessage ="Only 3 characthers is possible, Please try again")]
        public int CourseNumber { get; set; }
        [Required]
        [MaxLength(4, ErrorMessage ="Only 4 characthers is possible, Please try again")]
        public string CourseDepartment { get; set; }
        public double CourseCredits { get; set; }
        public string CourseInstructor { get; set; }
    }
}