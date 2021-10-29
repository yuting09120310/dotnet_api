using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class T625ProdMatch
    {
        public string ProdId { get; set; }
        public string Mac { get; set; }
        public string 貼紙mac { get; set; }
        public string 貼紙sn { get; set; }
        public string Model1 { get; set; }
        public string Model2 { get; set; }
        public string Model3 { get; set; }
        public string Model4 { get; set; }
        public string Model5 { get; set; }
        public DateTime Time { get; set; }
        public string Worker { get; set; }
    }
}
