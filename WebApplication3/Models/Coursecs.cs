using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Course
    {
        [Key]
        public int IdCourse { get; set; }

        public string name { get; set; }

        public int credit { get; set; }
    }
}
