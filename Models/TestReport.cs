using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class TestReport
    {
        public long Id { get; set; }
        public string 作業人員 { get; set; }
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 站別 { get; set; }
        public int 批量 { get; set; }
        public int? 工時 { get; set; }
        public int? 小時產出 { get; set; }
        public int? 測試時間 { get; set; }
        public int? 已測數量 { get; set; }
        public string 效率 { get; set; }
        public int? 良品數 { get; set; }
        public int? 不良品數 { get; set; }
        public string 不良率 { get; set; }
        public string 備註 { get; set; }
        public string 上傳時間 { get; set; }
    }
}
