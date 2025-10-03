using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class M2_form_factor
    {
        public int id { get; set; }
        [Required, MaxLength(10)]
        public string form { get; set; }
        public ICollection<M2> M2s { get; set; }
    }
}
