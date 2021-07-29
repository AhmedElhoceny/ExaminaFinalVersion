using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class PersonViewModel
    {
        public string Student_FullName { get; set; }
        public string Student_Email { get; set; }
        public string Student_PassWord { get; set; }
        public List<Courses> StudentCourses { get; set; }
    }
}
