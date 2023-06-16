using System.ComponentModel.DataAnnotations.Schema;

namespace AzureProject.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
        //navigation property
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
