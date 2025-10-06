using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class Manufacturer
    {
        public int id { get; set; }
        [Required, MaxLength(25)]
        public string name { get; set; }
        public ICollection<CPU> CPUs { get; set; }  
        public ICollection<CPU_Cooler> CPU_Coolers { get; set; }
        public ICollection<GPU> GPUs { get; set; }
        public ICollection<Motherboard> motherboards { get; set; }
        public ICollection<PS> PSs { get; set; }
        public ICollection<RAM> RAMs { get; set; }
        public ICollection<ROM> ROMs { get; set; }
    }
}
