using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class GPU
    {
        public int id { get; set; }
        [NotMapped]
        public string description { get { return $"{this.manufacturer} {this.brand} {this.model} {this.vram} {this.ram_type}"; } }
        [Required]
        public Manufacturer manufacturer { get; set; }
        [Required]
        public string brand { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public GPU_technology GPU_technology { get; set; }
        public int vram { get; set; }
        [Required]
        public RAM_type ram_type { get; set; }
        public int core_clock { get; set; }
        public int boost_clock { get; set; }
        [Required]
        public Component_interface gpu_interface { get; set; }
        [Required]
        public GPU_frame_sync GPU_frame_Sync { get; set; }
        public int tdp { get; set; }
        public int? hdmi_output { get; set; }
        public int? dp_port_output { get; set; }
        [Required]
        public int price { get; set; }
    }
}
