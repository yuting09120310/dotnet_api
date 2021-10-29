using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class OrderInformation
    {
        public string WorkOrder { get; set; }
        public string Model { get; set; }
        public int Block { get; set; }
        public int Quantity { get; set; }
        public long FlowId { get; set; }
    }
}
