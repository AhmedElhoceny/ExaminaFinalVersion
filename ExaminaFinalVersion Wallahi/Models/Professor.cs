using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class Professor
    {
        [Key]
        public int Professor_ID { get; set; }
        public string Professor_FullName { get; set; }
        public string Professor_Email { get; set; }
        public string Professor_Password { get; set; }
    }
}
