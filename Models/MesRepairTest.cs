using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class MesRepairTest
    {
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 製程站 { get; set; }
        public string 序號 { get; set; }
        public string 現象 { get; set; }
        public string 測試站 { get; set; }
        public int? 數量 { get; set; }
        public string 人員 { get; set; }
        public string 日期 { get; set; }
        public string 入帳時間 { get; set; }
        public string 客戶 { get; set; }
        public string 客戶機種 { get; set; }
        public string 不良代碼 { get; set; }
        public string 不良位置 { get; set; }
        public string 不良原因 { get; set; }
        public string 代碼 { get; set; }
        public string 自責 { get; set; }
        public string 他責 { get; set; }
        public string 維修時間 { get; set; }
        public string 修復 { get; set; }
        public string 備註 { get; set; }
        public string 維修人員 { get; set; }
        public string 上傳時間 { get; set; }
    }
}
