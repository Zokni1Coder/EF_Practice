using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class RAM
    {
        public int id { get; set; }
        public string model { get; set; }
        public Manufacturer manufacturer { get; set; }
        public int speed { get; set; }
        public RAM_type RAM_Type { get; set; }
        public int modul { get; set; }
        public int size { get; set; }
        public int CAS_Latency { get; set; }
        public double voltage { get; set; }
        public int price { get; set; }

    }
}
