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
    }
}
