using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Reading
    {
        [Key]
        public int Reading_ID { get; set; }
        public string Readings_Reading_Title { get; set; }
        public string Readings_Script { get; set; }
        public string Readings_Image { get; set; }
        public string Readings_Content { get; set; }
        public int Course_ID { get; set; }
    }
}
