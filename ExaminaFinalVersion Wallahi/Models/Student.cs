using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }
        public string Student_FullName { get; set; }
        public string Student_Email { get; set; }
        public string Student_PassWord { get; set; }
    }
}
