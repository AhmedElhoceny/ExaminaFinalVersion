using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class ContentViewModel
    {
        public Courses SearchedCourse { get; set; }
        public Exam Exams { get; set; }
        public Exam Grads { get; set; }
        public Picture Pictures { get; set; }
        public Project Projects { get; set; }
        public Reading Readings { get; set; }
        public Sheet Sheets { get; set; }
        public Video Videos { get; set; }
    }
}
