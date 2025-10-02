using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class CPU_Serie
    {
        public int id { get; set; }
        [Required]
        public string serie { get; set; }
        public ICollection<CPU> CPUs { get; set; }
    }
}
