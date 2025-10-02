using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class CPU
    {
        [Column(Order = 0)]
        public int id { get; set; }
        [Column(Order = 1), Required]
        public Manufacturer manufacturer { get; set; }
        [Column(Order = 2), Required]
        public CPU_Serie series { get; set; }
        [Column(Order = 4), Required]
        public CPU_Microarchitecture microarchitecture { get; set; }
        [Column(Order = 3), Required]
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
        [NotMapped]
        public string model { get { return $"{this.manufacturer} {this.series} {this.socket}"; } }
    }
}
