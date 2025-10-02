using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class CPU_Cooler
    {
        public int id { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public Manufacturer manufacturer { get; set; }
        public int fan_rpm { get; set; }
        public double noise_level { get; set; }
        public bool water_cooled { get; set; }
        public int price { get; set; }
        public ICollection<CPU_Socket> compatibility { get; set; }
    }
}
