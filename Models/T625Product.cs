using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class T625Product
    {
        public string BillNo { get; set; }
        public string ProdId { get; set; }
        public string Model1 { get; set; }
        public string Model2 { get; set; }
        public string Model3 { get; set; }
        public string Model4 { get; set; }
        public string SN { get; set; }
        public string Mac { get; set; }
        public string Package { get; set; }
        public DateTime? PackingTime { get; set; }
        public string Worker { get; set; }
    }
}
