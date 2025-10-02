using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class ROM_Type
    {
        public int id { get; set; }
        [Required]
        public string type { get; set; }
        public ICollection<ROM> ROMs { get; set; }
    }
}
