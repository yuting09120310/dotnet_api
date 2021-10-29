using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ErpWorkOrder
    {
        public string BillNo { get; set; }
        public string ProdId { get; set; }
        public int Quantity { get; set; }
        public string CustBillNo { get; set; }
        public string ClientId { get; set; }
        public string Client { get; set; }
        public string CustProdId { get; set; }
    }
}
