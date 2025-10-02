using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class CPU_Socket
    {
        public int id { get; set; }
        [Required]
        public string type { get; set; }
        public ICollection<CPU_Cooler> Cooler_compatibility { get; set; }
        public ICollection<CPU> CPUs { get; set; }
    }
}
