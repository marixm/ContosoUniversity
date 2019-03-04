using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Kambarys
    {
        [Key]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        [StringLength(50)]
        [Display(Name = "Student Room")]
        public string Location { get; set; }

        public virtual Student Student { get; set; }
    }
}