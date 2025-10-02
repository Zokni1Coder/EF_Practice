using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class RAM_type
    {
        public int id { get; set; }
        [Required]
        public string ram_type { get; set; }
        public ICollection<GPU> gpus { get; set; }
        public ICollection<Motherboard> motherboards { get; set; }
        public ICollection<RAM> RAMs { get; set; }
    }
}
