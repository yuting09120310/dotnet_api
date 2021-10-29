using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ProdMatList
    {
        public string BillNo { get; set; }
        public string ProdModel { get; set; }
        public string Quantity { get; set; }
        public string Caution { get; set; }
        public string MainProdId { get; set; }
        public string Type { get; set; }
        public string PartName { get; set; }
        public string ProSide { get; set; }
        public string Worker { get; set; }
        public string PushTime { get; set; }
    }
}
