using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class GPU_Interface
    {
        public int id { get; set; }
        public string gpu_interface { get; set; }
        public ICollection<GPU> gpus { get; set; }
    }
}
