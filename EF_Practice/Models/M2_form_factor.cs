using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class M2_form_factor
    {
        public int id { get; set; }
        public string form { get; set; }
        public ICollection<M2> M2s { get; set; }
    }
}
