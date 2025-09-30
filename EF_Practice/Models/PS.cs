using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Practice.Models
{
    public class PS
    {
        public int id { get; set; }
        public string model { get; set; }
        public Manufacturer manufacturer { get; set; }
        public PS_form_factor form { get; set; }
        public PS_Rating rating { get; set; }
        public int wattage { get; set; }
        public bool modularity { get; set; }
        public int price { get; set; }
    }
}
