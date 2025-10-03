using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class Motherboard_form_factor
    {
        public int id { get; set; }
        [Required, MaxLength(20)]
        public string form { get; set; }
        public ICollection<Motherboard> motherboards { get; set; }
    }
}
