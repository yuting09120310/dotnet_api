using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class OqcMesCheckList
    {
        public string 工單編號 { get; set; }
        public string 機種 { get; set; }
        public int 批量 { get; set; }
        public string 類別 { get; set; }
        public int 已驗數量 { get; set; }
        public int 送驗數量 { get; set; }
        public int 抽檢數量 { get; set; }
        public string 退貨標準 { get; set; }
        public string 抽檢結果 { get; set; }
        public string 退貨原因 { get; set; }
        public string 驗貨人員 { get; set; }
        public string 驗貨時間 { get; set; }
    }
}
