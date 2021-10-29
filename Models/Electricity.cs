using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class Electricity
    {
        public string 日期 { get; set; }
        public string 部門 { get; set; }
        public string 名字 { get; set; }
        public string 狀態 { get; set; }
        public DateTime 資料時間 { get; set; }
        public string 確認人員 { get; set; }
        public string 班別 { get; set; }
    }
}
