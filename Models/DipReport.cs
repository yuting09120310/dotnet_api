using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class DipReport
    {
        public string 日期 { get; set; }
        public string 廠別 { get; set; }
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public int 批量 { get; set; }
        public string 試產 { get; set; }
        public string 製程站 { get; set; }
        public int 生產數量 { get; set; }
        public int? 點數 { get; set; }
        public int? 總點數 { get; set; }
        public int 不良點數 { get; set; }
        public string 生產良率 { get; set; }
        public string 作業人員 { get; set; }
        public string 上傳時間 { get; set; }
    }
}
