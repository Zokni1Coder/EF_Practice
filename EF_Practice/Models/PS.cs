using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class PS
    {
        public int id { get; set; }
        [Required, MaxLength(20)]
        public string model { get; set; }
        [Required]
        public Manufacturer manufacturer { get; set; }
        [Required]
        public PS_form_factor form { get; set; }
        [Required]
        public PS_Rating rating { get; set; }
        public int wattage { get; set; }
        public bool modularity { get; set; }
        public string GetModularity()
        {
            return modularity ? "true" : "false";
        }
        public int price { get; set; }
    }
}
