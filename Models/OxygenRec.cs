using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class OxygenRec
    {
        public string 線別 { get; set; }
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public int 實際值 { get; set; }
        public string 檢查 { get; set; }
        public string 確認 { get; set; }
        public DateTime 時間 { get; set; }
    }
}
