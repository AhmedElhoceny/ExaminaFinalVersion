using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Requests
    {
        [Key]
        public int RequestID { get; set; }
        public int Request_StudentID { get; set; }
        public int Request_CourseID { get; set; }
    }
}
