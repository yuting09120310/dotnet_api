using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class PackageReport
    {
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 站別 { get; set; }
        public int 批量 { get; set; }
        public int 工時 { get; set; }
        public string 開始時間 { get; set; }
        public string 結束時間 { get; set; }
        public int? 產出 { get; set; }
        public int? 累計生產 { get; set; }
        public string 效率 { get; set; }
        public string 作業人員 { get; set; }
    }
}
