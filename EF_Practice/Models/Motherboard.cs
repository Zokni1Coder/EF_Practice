using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [NotMapped]
        public string description { get { return $"{this.manufacturer} {this.model} {this.motherboard_chipset} {this.socket} {this.motherboard_form_factor}{this.RAM_Type} "; } }
        [Column(Order = 1),Required]
        public Manufacturer manufacturer { get; set; }
        [Column(Order = 2),Required, MaxLength(20)]
        public string model { get; set; }
        [Column(Order = 3), Required]
        public CPU_Socket socket { get; set; }
        [Column(Order = 5), Required]
        public Motherboard_form_factor motherboard_form_factor { get; set; }
        [Column(Order = 4), Required]
        public Motherboard_chipset motherboard_chipset { get; set; }
        public int memory_max { get; set; }
        [Required]
        public RAM_type RAM_Type { get; set; }
        public int memory_slot_no { get; set; }
        public int sata_60gbs_no { get; set; }
        public bool onboard_ethernet { get; set; }
        public string GetEthernet()
        {
            return onboard_ethernet ? "yes" : "no"; 
        }
        public bool wifi { get; set; }
        public string GetWifi()
        {
            return wifi ? "yes" : "no";
        }
        public bool raid_supp { get; set; }
        public string GetRaidSupp()
        {
            return raid_supp ? "yes" : "no";
        }
        public int price { get; set; }
        public ICollection<M2> M2s { get; set; }
    }
}
