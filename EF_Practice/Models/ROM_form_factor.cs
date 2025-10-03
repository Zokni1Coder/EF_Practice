using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class ROM_form_factor
    {
        public int id { get; set; }
        [Required, MaxLength(10)]  
        public string form_factor { get; set; }
        public ICollection<ROM> ROMs { get; set; }
    }
}
