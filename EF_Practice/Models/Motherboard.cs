using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class Motherboard
    {
        public int id { get; set; }
        public Manufacturer manufacturer { get; set; }
        public string model { get; set; }
        public CPU_Socket socket { get; set; }
        public Motherboard_form_factor form_factor { get; set; }
        public Motherboard_chipset chipset { get; set; }
        public int memory_max { get; set; }
        public RAM_type RAM_Type { get; set; }
        public int memory_slot_no { get; set; }
        public int sata_60gbs_no { get; set; }
        public bool onboard_ethernet { get; set; }
        public bool wifi { get; set; }
        public bool raid_supp { get; set; }
        public int price { get; set; }
        public ICollection<M2> M2s { get; set; }
    }
}
