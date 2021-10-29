using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class MesRepairDip
    {
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public string 製程站 { get; set; }
        public string 序號 { get; set; }
        public string 現象 { get; set; }
        public string 位置 { get; set; }
        public int 數量 { get; set; }
        public string 人員 { get; set; }
        public string 日期 { get; set; }
        public string 入帳時間 { get; set; }
        public string 完修時間 { get; set; }
    }
}
