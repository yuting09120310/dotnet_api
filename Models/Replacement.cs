using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Replacement
    {
        public string 線別 { get; set; }
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 站別 { get; set; }
        public string 料號 { get; set; }
        public string 週期 { get; set; }
        public decimal 數量 { get; set; }
        public string 工號 { get; set; }
        public string 時間 { get; set; }
        public string Po { get; set; }
        public string 覆核人員 { get; set; }
        public string 覆核時間 { get; set; }
    }
}
