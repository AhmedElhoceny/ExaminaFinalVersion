using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Courses
    {
        [Key]
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public string Course_Image { get; set; }
        public int Professor_ID { get; set; }
    }
}
