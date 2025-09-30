using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class GPU_RAM_type
    {
        public int id { get; set; }
        public string ram_type { get; set; }
        public ICollection<GPU> gpus { get; set; }
    }
}
