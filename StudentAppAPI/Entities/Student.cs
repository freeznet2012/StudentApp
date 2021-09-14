using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentAppAPI.Entities
{
    [Keyless]
    [Table("Student")]
    public class Student
    {
        public int? FStudentId { get; set; }
        [StringLength(50)]
        public string FStudentName { get; set; }
        [StringLength(20)]
        public string FSubject { get; set; }
        public int? FMarks { get; set; }
    }

    
}