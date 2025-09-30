using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class PS_Rating
    {
        public int id { get; set; }
        public string rating { get; set; }
        public ICollection<PS> PSs { get; set; }
    }
}
