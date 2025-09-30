using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class ROM_form_factor
    {
        public int id { get; set; }
        public string form_factor { get; set; }
        public ICollection<ROM> ROMs { get; set; }
    }
}
