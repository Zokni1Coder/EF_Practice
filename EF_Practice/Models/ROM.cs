using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class ROM
    {
        public int id { get; set; }
        /// <summary>
        /// Gets or sets the model of the ROM.
        /// Example value: 990 Pro, Barracuda Compute,...
        /// </summary>
        [Required, MaxLength(25)]
        public string model { get; set; }
        [Required]
        public Manufacturer manufacturer { get; set; }
        public int capacity { get; set; }
        [Required]
        public ROM_Type type { get; set; }
        [Required]
        public ROM_form_factor form_Factor { get; set; }
        public bool nvme { get; set; }
        public int? rpm { get; set; }
        [Required]
        public Component_interface _interface { get; set; }
        public int price { get; set; }
    }
}
