using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class CPU_Microarchitecture
    {
        public int id { get; set; }
        public string architecture { get; set; }
        public ICollection<CPU> CPUs { get; set; }
    }
}
