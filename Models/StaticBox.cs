using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class StaticBox
    {
        public string 箱號 { get; set; }
        public string 卷數 { get; set; }
        public string 客戶別 { get; set; }
        public string 料號 { get; set; }
        public int? 數量 { get; set; }
        public string Dc { get; set; }
        public string 進料週期 { get; set; }
        public string Po { get; set; }
        public string 作業人員 { get; set; }
        public string 入箱時間 { get; set; }
    }
}
