using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class CPU
    {
        public int id { get; set; }
        public Manufacturer manufacturer { get; set; }
        public CPU_Series series { get; set; }
        public CPU_Microarchitecture microarchitecture { get; set; }
        public CPU_Socket socket { get; set; }
        public int core_count { get; set; }
        public int thread_count { get; set; }
        public double core_clock { get; set; }
        public double boost_core_clock { get; set; }
        public int L2_Cache { get; set; }
        public int L3_Cache { get; set; }
        public int tdp { get; set; }
        public int int_graph { get; set; }
        public int price { get; set; }
        public string model { get; set; }
    }
}
