using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class WhDeletelist
    {
        public string 資料庫 { get; set; }
        public string 刪除項目 { get; set; }
        public string 料號 { get; set; }
        public string 數量 { get; set; }
        public string 倉別 { get; set; }
        public string 時間 { get; set; }
        public string 刪除人員 { get; set; }
        public string 刪除時間 { get; set; }
    }
}
