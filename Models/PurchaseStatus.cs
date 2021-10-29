using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class PurchaseStatus
    {
        public decimal 單號 { get; set; }
        public string 主管 { get; set; }
        public string 處長 { get; set; }
        public string 採購 { get; set; }
        public string 代核 { get; set; }
        public string 副總 { get; set; }
        public string 最後簽核時間 { get; set; }
        public string 狀態 { get; set; }
        public string 作廢人員 { get; set; }
        public string 作廢原因 { get; set; }
        public string 作廢時間 { get; set; }
    }
}
