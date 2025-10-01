using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class Motherboard
    {
        [Column(name:"MotherboardID",Order = 0)]
        public int id { get; set; }
        [Column(Order = 1)]
        public Manufacturer manufacturer { get; set; }
        [Column(Order = 2)]
        public string model { get; set; }
        [Column(Order = 3)]
        public CPU_Socket socket { get; set; }
        [Column(Order = 5)]
        public Motherboard_form_factor motherboard_form_factor { get; set; }
        [Column(Order = 4)]
        public Motherboard_chipset motherboard_chipset { get; set; }
        public int memory_max { get; set; }
        public RAM_type RAM_Type { get; set; }
        public int memory_slot_no { get; set; }
        public int sata_60gbs_no { get; set; }
        public bool onboard_ethernet { get; set; }
        public bool wifi { get; set; }
        public bool raid_supp { get; set; }
        public int price { get; set; }
        [Column(Order = 6)]
        public ICollection<M2> M2s { get; set; }
    }
}
