using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class M2
    {
        public int id { get; set; }
        [Required]
        public M2_form_factor form { get; set; }
        public ICollection<Motherboard> motherboards { get; set; }
    }
}
