using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class CPU_Cooler
    {
        public ICollection<CPU_Socket> compatibility { get; set; }
        public int id { get; set; }

        public string model { get; set; }
        public Manufacturer manufacturer { get; set; }
        public int fan_rpm { get; set; }
        public double noise_level { get; set; }
        public bool water_cooled { get; set; }
        public int price { get; set; }
    }
}
