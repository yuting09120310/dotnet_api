using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Meet
    {
        public int Id { get; set; }
        public string 日期 { get; set; }
        public string 會議主旨 { get; set; }
        public string 與會人 { get; set; }
        public string 追蹤事項 { get; set; }
        public string 執行人員 { get; set; }
        public string 確認單位 { get; set; }
        public string 完成時間 { get; set; }
        public string 是否結束 { get; set; }
        public string 備註 { get; set; }
    }
}
