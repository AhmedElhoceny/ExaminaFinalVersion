using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Exam
    {
        [Key]
        public int Exam_ID { get; set; }
        public string Exam_Title { get; set; }
        public string Exam_Script { get; set; }
        public string Exam_Image { get; set; }
        public string Exam_Distenation { get; set; }
        public int Course_ID { get; set; }
    }
}
