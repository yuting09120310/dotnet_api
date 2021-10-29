using System;
using System.Collections.Generic;

#nullable disable

namespace api.Models
{
    public partial class ReflowRec
    {
        public string 線別 { get; set; }
        public string 製令 { get; set; }
        public string 機種 { get; set; }
        public int 上1區 { get; set; }
        public int 上2區 { get; set; }
        public int 上3區 { get; set; }
        public int 上4區 { get; set; }
        public int 上5區 { get; set; }
        public int 上6區 { get; set; }
        public int 上7區 { get; set; }
        public int 上8區 { get; set; }
        public int? 上9區 { get; set; }
        public int? 上10區 { get; set; }
        public int 下1區 { get; set; }
        public int 下2區 { get; set; }
        public int 下3區 { get; set; }
        public int 下4區 { get; set; }
        public int 下5區 { get; set; }
        public int 下6區 { get; set; }
        public int 下7區 { get; set; }
        public int 下8區 { get; set; }
        public int? 下9區 { get; set; }
        public int? 下10區 { get; set; }
        public string 速率 { get; set; }
        public string 執行 { get; set; }
        public string 確認 { get; set; }
        public DateTime 時間 { get; set; }
    }
}
