using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class CourseContentViewModel
    {
        public Courses SearchedCourse { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Exam> Grads { get; set; }
        public List<Picture> Pictures { get; set; }
        public List<Project> Projects { get; set; }
        public List<Reading> Readings { get; set; }
        public List<Sheet> Sheets { get; set; }
        public List<Video> Videos { get; set; }
    }
}
