using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class Component_interface
    {
        [Column(Order =0)]
        public int id { get; set; }
        /// <summary>
        /// Gets or sets interface types of the component. Example: PCIe, M.2, SATA,...
        /// </summary>
        [Required, MaxLength(20)]
        public string interface_type { get; set; }
        public ICollection<GPU> gpus { get; set; }
        public ICollection<ROM> ROMs { get; set; }
    }
}
