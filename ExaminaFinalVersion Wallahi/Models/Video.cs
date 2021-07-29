using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Video
    {
        [Key]
        public int Video_ID { get; set; }
        public string Video_Title { get; set; }
        public int Video_script { get; set; }
        public string Video_Image { get; set; }
        public string Video_Distenation { get; set; }
        public int Course_ID { get; set; }
    }
}
