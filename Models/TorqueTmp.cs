using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class TorqueTmp
    {
        public string 項目 { get; set; }
        public DateTime? 日期 { get; set; }
        public string 機種 { get; set; }
        public string 製程 { get; set; }
        public string 編號 { get; set; }
        public string 標準扭力值 { get; set; }
        public string 誤差值 { get; set; }
        public string 測試扭力值 { get; set; }
        public string 電動起子編號 { get; set; }
        public string 蜂鳴器 { get; set; }
        public string 量測人員 { get; set; }
        public DateTime 量測時間 { get; set; }
    }
}
