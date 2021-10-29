using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class FeederNumber
    {
        public string 料架號碼 { get; set; }
        public string 客戶別 { get; set; }
        public string 料號 { get; set; }
        public int? 數量 { get; set; }
        public string Dc { get; set; }
        public string 進料週期 { get; set; }
        public string Po { get; set; }
        public string 上料人員 { get; set; }
        public string 上料時間 { get; set; }
    }
}
