using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class ROM
    {
        public int id { get; set; }
        public string model { get; set; }
        public Manufacturer manufacturer { get; set; }
        public int capacity { get; set; }
        public ROM_Type type { get; set; }
        public ROM_form_factor form_Factor { get; set; }
        public bool nvme { get; set; }
        public int? rpm { get; set; }
        public Interfaces _interface { get; set; }
        public int price { get; set; }
    }
}
