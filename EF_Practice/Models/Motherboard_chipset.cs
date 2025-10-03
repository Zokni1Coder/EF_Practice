using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class Motherboard_chipset
    {
        public int id { get; set; }
        [Required, MaxLength(15)]
        public string chipset { get; set; }
        public ICollection<Motherboard> motherboards { get; set; }

    }
}
