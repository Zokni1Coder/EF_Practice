using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class PS_Rating
    {
        public int id { get; set; }
        [Required, MaxLength(10)]
        public string rating { get; set; }
        public ICollection<PS> PSs { get; set; }
    }
}
