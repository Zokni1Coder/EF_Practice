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
        /// <summary>
        /// Gets a human-readable description of the GPU.
        /// Example value: MSI GeForce RTX 3060 Ventus Limited Edition 12GB. 
        /// </summary>
        [NotMapped]
        public string description { get { return $"{this.manufacturer} {this.brand} {this.GPU_technology} {this.model} {this.additional_info} {this.vram}GB"; } }
        /// <summary>
        /// Gets or sets additional product information, such as 
        /// manufacturer-specific designations.
        /// Example value: .
        /// </summary>
        [MaxLength(20)]
        public string additional_info { get; set; }
        [Required]
        public Manufacturer manufacturer { get; set; }
        /// <summary>
        /// Gets or sets the brand of the GPU.
        /// Example value: GeForce, Ventus 2X,...
        /// </summary>
        [MaxLength(25)]
        public string brand { get; set; }
        /// <summary>
        /// Gets or sets the model of the GPU.
        /// Example value: 4090, 1080 Ti, 7800XT,...
        /// </summary>
        [Required, MaxLength(25)]
        public string model { get; set; }
        [Required]
        public GPU_technology GPU_technology { get; set; }
        [Required]
        public int vram { get; set; }
        [Required]
        public RAM_type ram_type { get; set; }
        [Required]
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
