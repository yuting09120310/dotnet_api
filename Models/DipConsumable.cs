using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class DipConsumable
    {
        public string 品名 { get; set; }
        public string 規格 { get; set; }
        public double? 數量 { get; set; }
        public double? 安全數量 { get; set; }
        public string 操作人員 { get; set; }
        public string 操作時間 { get; set; }
    }
}
