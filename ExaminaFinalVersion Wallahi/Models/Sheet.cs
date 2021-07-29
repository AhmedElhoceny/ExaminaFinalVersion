using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Sheet
    {
        [Key]
        public int Sheet_ID { get; set; }
        public string Sheet_Title { get; set; }
        public string Sheet_Script { get; set; }
        public string Sheet_Image { get; set; }
        public string Sheet_Distenation { get; set; }
        public int Course_ID { get; set; }
    }
}
