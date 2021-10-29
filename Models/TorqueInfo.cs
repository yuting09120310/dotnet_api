using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class TorqueInfo
    {
        public string 機種 { get; set; }
        public string 製程 { get; set; }
        public string 編號 { get; set; }
        public decimal 標準扭力值 { get; set; }
        public decimal 誤差值 { get; set; }
        public string 人員 { get; set; }
        public DateTime 時間 { get; set; }
    }
}
