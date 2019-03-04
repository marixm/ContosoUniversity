using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Iranga
    {
        [Key]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        [StringLength(50)]
        [Display(Name = "Room Facilities")]
        public string Location { get; set; }

        public virtual Student Student { get; set; }
    }
}