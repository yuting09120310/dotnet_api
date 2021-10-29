using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class PcbaTransferRec
    {
        public string 製令 { get; set; }
        public string 工單 { get; set; }
        public string 機種 { get; set; }
        public string 客戶機種 { get; set; }
        public int 批量 { get; set; }
        public string 轉出單位 { get; set; }
        public string 轉出人員 { get; set; }
        public string 接收單位 { get; set; }
        public string 接收人員 { get; set; }
        public int? 數量 { get; set; }
        public DateTime? 時間 { get; set; }
        public string 備註 { get; set; }
    }
}
