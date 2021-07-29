using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Picture
    {
        [Key]
        public int Picture_ID { get; set; }
        public string Picture_Title { get; set; }
        public string Picture_Script { get; set; }
        public string Picture_Image { get; set; }
        public string Picture_Distenation { get; set; }
        public int Course_ID { get; set; }
    }
}
