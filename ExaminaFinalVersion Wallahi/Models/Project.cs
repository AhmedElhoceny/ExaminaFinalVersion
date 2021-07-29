
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Project
    {
        [Key]
        public int Project_ID { get; set; }
        public string Project_Title { get; set; }
        public string Project_Script { get; set; }
        public string Project_Image { get; set; }
        public string Project_Distenation { get; set; }
        public int Course_ID { get; set; }
    }
}
