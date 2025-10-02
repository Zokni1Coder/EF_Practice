using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class GPU_frame_sync
    {
        public int id { get; set; }
        [Required]
        public string sync { get; set; }
        public ICollection<GPU> gpus { get; set; }

    }
}
