using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class CourseStudentRelationship
    {
        [Key]
        public int CourseStudentRelationshipID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
    }
}
