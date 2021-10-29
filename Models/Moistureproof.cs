using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Moistureproof
    {
        public string 客戶別 { get; set; }
        public string 原廠料號 { get; set; }
        public string 料單料號 { get; set; }
        public string 數量 { get; set; }
        public string 儲位 { get; set; }
        public string 放入時間 { get; set; }
        public string 放入人員 { get; set; }
        public string 取出時間 { get; set; }
        public string 取出人員 { get; set; }
        public string 結案 { get; set; }
    }
}
