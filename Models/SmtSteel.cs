using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class SmtSteel
    {
        public string 機種 { get; set; }
        public string 鋼板編號 { get; set; }
        public string 印刷次數 { get; set; }
        public string 線別 { get; set; }
        public string 測量1 { get; set; }
        public string 測量2 { get; set; }
        public string 測量3 { get; set; }
        public string 測量4 { get; set; }
        public string 測量5 { get; set; }
        public string 取用者 { get; set; }
        public string 上線時間 { get; set; }
        public string 歸還者 { get; set; }
        public string 下線時間 { get; set; }
        public string 清潔鋼板 { get; set; }
    }
}
