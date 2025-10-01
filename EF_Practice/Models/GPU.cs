using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class GPU
    {
        public int id { get; set; }
        public string model { get; set; }
        public ICollection<Manufacturer> manufacturer { get; set; }
        public string brand { get; set; }
        public GPU_technology GPU_technology { get; set; }
        public int vram { get; set; }
        public RAM_type ram_type { get; set; }
        public int core_clock { get; set; }
        public int boost_clock { get; set; }
        public Component_interface gpu_interface { get; set; }
        public GPU_frame_sync GPU_frame_Sync { get; set; }
        public int tdp { get; set; }
        public int hdmi_output { get; set; }
        public int dp_port_output { get; set; }
        public int price { get; set; }
    }
}
