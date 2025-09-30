using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class Interfaces
    {
        public int id { get; set; }
        public string interface_type { get; set; }
        public ICollection<GPU> gpus { get; set; }
        public ICollection<ROM> ROMs { get; set; }
    }
}
